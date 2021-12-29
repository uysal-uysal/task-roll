using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taskroll
{
    public partial class ramDetails : Form
    {
        public ramDetails()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                //get physicalmemory properties from win32 api
                ManagementClass cimobject1 = new ManagementClass("Win32_PhysicalMemory");
                ManagementObjectCollection moc1 = cimobject1.GetInstances();
                double available = 0, capacity = 0;
                string manufacturer = "";
                string name = "";
                string serialNumber = "";
                string tag = "";


                //get capacity manufacturer and name of physicalmemory
                foreach (ManagementObject mo1 in moc1)
                {
                    capacity += ((Math.Round(Int64.Parse(mo1.Properties["Capacity"].Value.ToString()) / 1024 / 1024 / 1024.0, 1)));
                    manufacturer = mo1.Properties["Manufacturer"].Value.ToString();
                    name = mo1.Properties["Name"].Value.ToString();
                    serialNumber += mo1.Properties["SerialNumber"].Value.ToString();
                    tag += mo1.Properties["Tag"].Value.ToString() + " ";
                }
                moc1.Dispose();
                cimobject1.Dispose();


                //get available memory
                ManagementClass cimobject2 = new ManagementClass("Win32_PerfFormattedData_PerfOS_Memory");
                ManagementObjectCollection moc2 = cimobject2.GetInstances();
                foreach (ManagementObject mo2 in moc2)
                {
                    available += ((Math.Round(Int64.Parse(mo2.Properties["AvailableMBytes"].Value.ToString()) / 1024.0, 1)));

                }
                moc2.Dispose();
                cimobject2.Dispose();

                chartRam.Series["Ram"].Points.AddY((int)Math.Round((capacity - available) / capacity * 100, 0));

                ramProgress.Value = ((int)Math.Round((capacity - available) / capacity * 100, 0));
                
                labelTag.Text = "Tag : " + " " + tag + " ";
                labelSerialNumber.Text = "Serial Number : " + " " + serialNumber;
                labelName.Text = "Name : " + " " + name;
                labelManufacturer.Text = "Manufacturer : " + " " + manufacturer;
                labelCapacity.Text = " Capacity : " + " " + capacity.ToString() + " GB";
                labelAvailable.Text = "Available : " + " " + available.ToString() + " GB";
                labelUsing.Text = "Ram Usage : " + ((capacity - available)).ToString() + " GB, " + (Math.Round((capacity - available) / capacity * 100, 0)).ToString() + " %";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
