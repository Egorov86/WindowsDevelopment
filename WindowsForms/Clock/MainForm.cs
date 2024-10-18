using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class MainForm : Form
    {
        ColorDialog backgroundColorDialog; //можно было затащить из формы
        ColorDialog foregroundColorDialog;
        public MainForm()
        {
            InitializeComponent();
            this.TransparencyKey = Color.Empty;
            backgroundColorDialog = new ColorDialog();
            foregroundColorDialog = new ColorDialog();
            SetVisibility(false); // отображение только часов
            this.Location = new Point
                (
                     System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - this.Width,
                     50
                );
            this.Text += $" Location:{this.Location.X}x{this.Location.Y}y";


        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            labeltime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            if (cbShowDate.Checked)
            {
                labeltime.Text += $"\n{DateTime.Today.ToString("yyyy.MM.dd")}";
            }
            //notifyIconSystemTray.BalloonTipText = "Current time" + labeltime.Text;
        }
        private void SetVisibility(bool visible)
        {
            this.TransparencyKey = visible ? Color.Empty : this.BackColor; //обращение к объекту данной формы
            this.FormBorderStyle = visible ? FormBorderStyle.Sizable : FormBorderStyle.None; //форма элемента SIZABLE скрыть
            this.ShowInTaskbar = visible; //скрытие в панели задач
            cbShowDate.Visible = visible;
            btnHideControls.Visible = visible;
            labeltime.BackColor = visible ? Color.Empty : backgroundColorDialog.Color ; //изменение цвета
            // taskkill /f /im clock.exe  (закрыть окно)
        }
        private void btnHideControls_Click(object sender, EventArgs e)
        {
            showControlsToolStripMenuItem.Checked = false;
            //string filename;
            //if(FolderBrowserDialog.ReferenceEquals() == DialogResult.OK)
            //Hide();
            //SetVisibility(false);
            //notifyIconSystemTray.BalloonTipText = "Обратите внимание что программа продолжит работу в фоновом режиме!";
            notifyIconSystemTray.ShowBalloonTip(3, "Alert!", "Для того чтобы вернуть", ToolTipIcon.Info);
        }

        private void labeltime_DoubleClick(object sender, EventArgs e)
        {
            showControlsToolStripMenuItem.Checked = false;

        }
        private void notifyIconSystemTray_MouseMove(object sender, MouseEventArgs e)
        {
            notifyIconSystemTray.Text = "Current  time:\n" + labeltime.Text;
        }

        private void ShowContextMenu_RightClick(object sender, MouseEventArgs e)
        {
            this.contextMenuStrip.Visible = Visible;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void topmostToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = topmostToolStripMenuItem.Checked; // поверх всех окон откл/вкл галоч
        }
        private void showControlsToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            SetVisibility(((ToolStripMenuItem)sender).Checked);
            //MessageBox.Show("Show controls toolstrip menu");
        }

        private void cbShowData_CheckedChanged(object sender, EventArgs e)
        {
            showDataToolStripMenuItem.Checked = cbShowDate.Checked; //
        }

        private void showDataToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            cbShowDate.Checked = showDataToolStripMenuItem.Checked;
        }

        private void notifyIconSystemTray_DoubleClick(object sender, EventArgs e)
        {
            if (!this.TopMost)
            {
                this.TopMost = true;
                this.TopMost = false;
            }
        }

        private void foregraundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (foregroundColorDialog.ShowDialog(this) == DialogResult.OK)
            {
                labeltime.ForeColor = foregroundColorDialog.Color;
            }
        }

        private void backgraundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (backgroundColorDialog.ShowDialog(this) == DialogResult.OK)
            {
                labeltime.BackColor = backgroundColorDialog.Color;
            }
        }
    }
}
