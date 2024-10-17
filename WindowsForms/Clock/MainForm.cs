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
        private void timer1_Tick(object sender, EventArgs e)
        {
            labeltime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            if(cbShowDate.Checked)
            {
                labeltime.Text += $"\n{DateTime.Today.ToString("yyyy.MM.dd")}";
            }
            //notifyIconSystemTray.BalloonTipText = "Current time" + labeltime.Text;
        }
        private void SetVisibility(bool visible)
        {
            this.TransparencyKey = visible ? Color.Empty :this.BackColor; //обращение к объекту данной формы
            this.FormBorderStyle = visible ? FormBorderStyle.Sizable: FormBorderStyle.None; //форма элемента SIZABLE скрыть
            this.ShowInTaskbar = visible; //скрытие в панели задач
            cbShowDate.Visible = visible;
            btnHideControls.Visible = visible; 
            labeltime.BackColor = visible ? Color.Empty : Color.Coral; //изменение цвета
            // taskkill /f /im clock.exe  (закрыть окно)
        }
        private void btnHideControls_Click(object sender, EventArgs e)
        {
            //string filename;
            //if(FolderBrowserDialog.ReferenceEquals() == DialogResult.OK)
            //Hide();
            SetVisibility(false);
            notifyIconSystemTray.BalloonTipText = "Обратите внимание что программа продолжит работу в фоновом режиме!";
            notifyIconSystemTray.ShowBalloonTip(1000);
        }

        private void labeltime_DoubleClick(object sender, EventArgs e)
        {
            SetVisibility(true);
            
        }
        private void notifyIconSystemTray_MouseMove(object sender, MouseEventArgs e)
        {
            notifyIconSystemTray.Text = "Current  time:\n" + labeltime.Text;
        }

        private void ShowContextMenu_RightClick(object sender, MouseEventArgs e)
        {
            this.contextMenuStrip1.Visible = Visible;
        }
    }
}
