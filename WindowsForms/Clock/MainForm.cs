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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.TransparencyKey = Color.Empty;
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
            //notifyIconSystemTray.BalloonTipText = "Current time" + labeltime.Text;
        }
        private void setVisibility(bool visible)
        {
            this.TransparencyKey = visible ? Color.Empty :this.BackColor;
            this.FormBorderStyle = visible ? FormBorderStyle.Sizable: FormBorderStyle.None;
            this.ShowInTaskbar = visible;
            cbShowDate.Visible = visible;
            btnHideControls.Visible = visible;
            labeltime.BackColor = visible ? Color.Empty : Color.Coral;
        }
        private void btnHideControls_Click(object sender, EventArgs e)
        {
            setVisibility(false);
            notifyIconSystemTray.ShowBalloonTip(1, "Важная инфа", "надо нажать два раза", ToolTipIcon.Error);
        }

        private void labeltime_DoubleClick(object sender, EventArgs e)
        {
            setVisibility(true);
            
        }
        private void notifyIconSystemTray_MouseMove(object sender, MouseEventArgs e)
        {
            notifyIconSystemTray.Text = "Current time:\n" + labeltime.Text;
        }
    }
}
