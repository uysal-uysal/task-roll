using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taskroll
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Start();
            this.Hide();
            Main main = new Main();
            main.Show();
            timer.Stop();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }
    }
}
