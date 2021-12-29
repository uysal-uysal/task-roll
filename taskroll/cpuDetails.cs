using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taskroll
{
    public partial class cpuDetails : Form
    {
        public cpuDetails()
        {
            InitializeComponent();
        }

        PerformanceCounter cpuCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");


        private void cpuDetails_Load(object sender, EventArgs e)
        {
            try
            {
                //get processor properties from win32
                SelectQuery Sq = new SelectQuery("Win32_Processor");
                ManagementObjectSearcher objOSDetails = new ManagementObjectSearcher(Sq);
                ManagementObjectCollection osDetailsCollection = objOSDetails.Get();
                StringBuilder sb = new StringBuilder();
                foreach (ManagementObject mo in osDetailsCollection)
                {
                    labelSystem.Text = string.Format("SystemName: {0}", (string)mo["SystemName"]);
                    labelCpuId.Text = string.Format("ProcessorId: {0}", (string)mo["ProcessorId"]);
                    labelName.Text = string.Format("Name : {0}", (string)mo["Name"]);
                    labelCores.Text = (string.Format("NumberOfCores : {0}", mo["NumberOfCores"]).ToString());
                    labelLogicalProcessors.Text = string.Format("NumberOfLogicalProcessors : {0}", mo["NumberOfLogicalProcessors"]).ToString();
                    labelCurrentClock.Text = string.Format("BaseSpeed : {0}", mo["CurrentClockSpeed"]).ToString() + " " + "mhz";
                    labelManufacturer.Text = string.Format("Manufacturer: {0}", (string)mo["Manufacturer"]);
                }
                objOSDetails.Dispose();
                osDetailsCollection.Dispose();  
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //fcpu--> processor usage 
            float fcpu = cpuCounter.NextValue();
            progressBar1.Value = (int)fcpu;
            labelCpu.Text = "Cpu Usage : " + " " + (int)fcpu + " " + "%";
            chartCpu.Series["Cpu"].Points.AddY((int)Math.Round(fcpu, 0));
        }
    }
}
