using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labeltime_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labeltime.Text = DateTime.Now.ToString("HH:mm:ss tt");
            if(cbShowDate.Checked)
            {
                labeltime.Text += $"\n{DateTime.Today.ToString("yyyy.MM.dd")}";
            }
;       }
    }
}
