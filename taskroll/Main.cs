using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace taskroll
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Utilities utilities = new Utilities();  
            getForm(utilities);
        }

        private void getForm(Form frm)
        {
            //put the other forms on main panel
            mainPanel.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            mainPanel.Controls.Add(frm);
            frm.Show();
        }

        private void stripMenuProcesses_Click(object sender, EventArgs e)
        {
            Processes processes = new Processes();
            getForm(processes);
        }

        private void stripMenuCpu_Click(object sender, EventArgs e)
        {
            cpuDetails cpuDetails = new cpuDetails();
            getForm(cpuDetails);
        }

        private void stripMenuRam_Click(object sender, EventArgs e)
        {
            ramDetails ramDetails = new ramDetails();
            getForm(ramDetails);
        }

        private void stripMenuMain_Click(object sender, EventArgs e)
        {
            Utilities utilities = new Utilities();
            getForm(utilities);
        }
    }
}
