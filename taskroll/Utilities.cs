using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taskroll
{
    public partial class Utilities : Form
    {
        //battery status dictionary
        Dictionary<UInt16, string> StatusCodes;


        //dll import for adjust system volume
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg,
      IntPtr wParam, IntPtr lParam);

        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;


        public Utilities()
        {
            InitializeComponent();
        }

        //performance counters from Windows Performance Monitor
        PerformanceCounter diskRead = new PerformanceCounter("PhysicalDisk", "Disk Read Bytes/sec", "_Total");
        PerformanceCounter diskWrite = new PerformanceCounter("PhysicalDisk", "Disk Write Bytes/sec", "_Total");

        BackgroundWorker bgwConnection;

        //connected network ssid and signal
        string ssid = "";
        string signal = "";

       
        private void Utilities_Load(object sender, EventArgs e)
        {
            //check connection
            CheckForIllegalCrossThreadCalls = false;
            bgwConnection = new BackgroundWorker();
            bgwConnection.DoWork += bgwConnectionDo;
            timerConnection.Start();


            //set default value to disk combobox
            foreach (var drive in DriveInfo.GetDrives())
            {
                comboBoxDisk.Items.Add(drive);
            }
                //if (!comboBoxDisk.Items.Contains(drive))
                comboBoxDisk.SelectedIndex = 0;

            try
            {
                //set brightness by trackbars value
                trackBarBrightness.Value = Get();

                //battery status codes
                StatusCodes = new Dictionary<ushort, string>();
                StatusCodes.Add(1, "The battery is discharging");
                StatusCodes.Add(2, "The system has access to AC.");
                StatusCodes.Add(3, "Fully Charged");
                StatusCodes.Add(4, "Low");
                StatusCodes.Add(5, "Critical");
                StatusCodes.Add(6, "Charging");
                StatusCodes.Add(7, "Charging and High");
                StatusCodes.Add(8, "Charging and Low");
                StatusCodes.Add(9, "Undefined");
                StatusCodes.Add(10, "Partially Charged");

                //get battery information from win32
                ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from Win32_Battery");

                foreach (ManagementObject mo in mos.Get())
                {
                    labelBatteryName.Text = mo["Name"].ToString();
                    UInt16 statuscode = (UInt16)mo["BatteryStatus"];
                    string statusString = StatusCodes[statuscode];
                    labelBatteryStatus.Text = "Battery Status: "  + statusString;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static int Get()
        {
            //get system brightness
            var mclass = new ManagementClass("WmiMonitorBrightness")
            {
                Scope = new ManagementScope(@"\\.\root\wmi")
            };
            var instances = mclass.GetInstances();
            foreach (ManagementObject instance in instances)
            {
                return (byte)instance.GetPropertyValue("CurrentBrightness");
            }
            return 0;
        }

        public static void Set(int brightness)
        {
            //set brightness
            try
            {
                var mclass = new ManagementClass("WmiMonitorBrightnessMethods")
                {
                    Scope = new ManagementScope(@"\\.\root\wmi")
                };
                var instances = mclass.GetInstances();
                var args = new object[] { 1, brightness };
                foreach (ManagementObject instance in instances)
                {
                    instance.InvokeMethod("WmiSetBrightness", args);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void trackBarBrightness_Scroll(object sender, EventArgs e)
        {
            Set(trackBarBrightness.Value);
        }

        private void buttonMute_Click(object sender, EventArgs e)
        {
            //mute 
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
            (IntPtr)APPCOMMAND_VOLUME_MUTE);
        }

        private void buttonDec_Click(object sender, EventArgs e)
        {
            //decrease system volume
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
            (IntPtr)APPCOMMAND_VOLUME_DOWN);
        }

        private void buttonInc_Click(object sender, EventArgs e)
        {
            //increase system volume
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
            (IntPtr)APPCOMMAND_VOLUME_UP);
        }

        private void buttonTurnOff_Click(object sender, EventArgs e)
        {
            //turn of the system
            var psi = new ProcessStartInfo("shutdown", "/s /t 0");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            //restart system
            var psi = new ProcessStartInfo("shutdown", "/r /t 0");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }

        private void buttonSleep_Click(object sender, EventArgs e)
        {
            //hibernate
            Application.SetSuspendState(PowerState.Hibernate, true, true);
        }

        private int RemainingBattery()
        {
            //get remaining battery percentage
            PowerStatus p = SystemInformation.PowerStatus;
            return (int)(p.BatteryLifePercent * 100);
        }


        //get connected network properties
        private void connectedNetwork()
        {
            Process p = new Process();
            p.StartInfo.FileName = "netsh.exe";
            p.StartInfo.Arguments = "wlan show interfaces";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.Start();

            string s = p.StandardOutput.ReadToEnd();
            string s1 = s.Substring(s.IndexOf("SSID"));
            s1 = s1.Substring(s1.IndexOf(":"));
            s1 = s1.Substring(2, s1.IndexOf("\n")).Trim();

            string s2 = s.Substring(s.IndexOf("Signal"));
            s2 = s2.Substring(s2.IndexOf(":"));
            s2 = s2.Substring(2, s2.IndexOf("\n")).Trim();

            ssid = s1;
            signal = s2;
            p.WaitForExit();

        }
        
        //get connected network properties
        private void yesConnection_Click(object sender, EventArgs e)
        {
            connectedNetwork();
            string temp = string.Empty;
            temp += "SSID : " + ssid + "\n";
            temp += "Signal : " + signal;
            MessageBox.Show(temp);
        }

        //set connection icons according to connection
        private void bgwConnectionDo(object sender, DoWorkEventArgs e)
        {
            if (!connStatus())
            {
                yesConnection.Visible = false;
                noConnection.Visible = true;
            }
            else
            {
                noConnection.Visible = false;
                yesConnection.Visible = true;
            }
        }

        private void timerConnection_Tick(object sender, EventArgs e)
        {
            if (!bgwConnection.IsBusy)
            {
                bgwConnection.RunWorkerAsync();
            }
        }

        public bool connStatus()
        {
            bool conn = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
            return conn;

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //((diskRead.NextValue() / 1024f) / 1024f) --> byte to mb
            try
            {
                //take all disks and add to combobox
                //çözülecek

                //get disk usages and informations
                string disk = comboBoxDisk.SelectedItem.ToString();
                DriveInfo driveInfo = new DriveInfo(disk);

                long availableFreeSpace = driveInfo.AvailableFreeSpace;
                string driveFormat = driveInfo.DriveFormat;
                string name = driveInfo.Name;
                long totalSize = driveInfo.TotalSize;

                labelDiskRead.Text = "Read Megabytes/sec : " + " " + (diskRead.NextValue() / 1024f / 1024f);
                labelDiskWrite.Text = "Write Megabytes/sec : " + " " + (diskWrite.NextValue() / 1024f / 1024f);
                labelDiskAvailable.Text = "Available Space : " + " " + (Math.Round(availableFreeSpace * (1d / 1024 / 1024 / 1024), 2)).ToString() + " GB";
                labelDiskFormat.Text = "Disk Format : " + " " + driveFormat.ToString();
                labelDiskTotal.Text = "Total Space : " + " " + (Math.Round(totalSize * (1d / 1024 / 1024 / 1024), 2)).ToString() + " GB";
                labelDiskName.Text = "Disk Name : " + " " + name;


                //battery informations
                ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from Win32_Battery where Name='" + labelBatteryName.Text + "'");
                foreach (ManagementObject mo in mos.Get())
                {
                    UInt16 statuscode = (UInt16)mo["BatteryStatus"];
                    string statusString = StatusCodes[statuscode];
                    labelBatteryStatus.Text = statusString;
                    labelRemaining.Text = "Remaining Battery : " + " " + RemainingBattery().ToString() + "%";

                    //set color according to status
                    if (statuscode == 4)
                    {
                        progressBarBattery.ForeColor = Color.Red;
                        progressBarBattery.Value = 5;
                    }
                    else if (statuscode == 3)
                    {
                        progressBarBattery.ForeColor = Color.Blue;
                        progressBarBattery.Value = 100;
                    }
                    else if (statuscode == 2)
                    {
                        progressBarBattery.ForeColor = Color.Green;
                        progressBarBattery.Value = 100;
                    }
                    else if (statuscode == 5)
                    {
                        progressBarBattery.ForeColor = Color.Red;
                        progressBarBattery.Value = 1;
                    }
                    else if (statuscode == 6)
                    {
                        progressBarBattery.ForeColor = Color.Blue;
                        progressBarBattery.Value = 100;
                    }
                    else
                    {
                        progressBarBattery.Value = RemainingBattery();
                    }
                }
                mos.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
