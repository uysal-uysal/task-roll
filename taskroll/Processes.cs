using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taskroll
{
    public partial class Processes : Form
    {
        public Processes()
        {
            InitializeComponent();
        }

        private void Processes_Load(object sender, EventArgs e)
        {
            GetProcesses();
            listProcess.SelectedIndex = 0;
        }

        PerformanceCounter interruptCounter = new PerformanceCounter("Processor Information", "Interrupts/sec", "_Total");


        private void GetProcesses()
        {
            //get&list processes
            listProcess.Items.Clear();
            Process[] task = Process.GetProcesses();
            foreach (Process proc in task)
            {
                listProcess.Items.Add(proc.ProcessName);
            }
        }

        private void btnGetProcess_Click(object sender, EventArgs e)
        {
            GetProcesses();
        }

        private void btnEndProcess_Click(object sender, EventArgs e)
        {
            //kill the selected process
            Process[] task = Process.GetProcesses();
            foreach (Process proc in task)
            {
                if (listProcess.SelectedItem.ToString() == proc.ProcessName)
                {
                    proc.Kill();
                    GetProcesses();
                    break;
                }
            }
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            //get selected process properties
            Process[] task = Process.GetProcesses();
            foreach (Process proc in task)
            {
                if (listProcess.SelectedItem.ToString() == proc.ProcessName)
                {
                    string temp = string.Empty;
                    temp += "Process id :" + proc.Id.ToString();
                    temp += "\nProcess name :" + proc.ProcessName.ToString();
                    temp += "\nUser Time :" + proc.UserProcessorTime.ToString();
                    temp += "\nStart Time :" + proc.StartTime.ToString();
                    MessageBox.Show(temp);
                    break;
                }
            }
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            //count acvite process number
            Process[] task = Process.GetProcesses();
            int activeCounter = task.Length;
            labelActiveProcesses.Text = "Number of Active Processes: " + activeCounter;

            float interrupts = interruptCounter.NextValue();
            labelInterrupts.Text = "Interrupts : " + " " + (int)interrupts;
            chartInterrupts.Series["Interrupts"].Points.AddY((int)Math.Round(interrupts, 0));
        }
    }
}
