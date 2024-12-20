﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using System.Text;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Reflection.Emit;
using MediaPlayer;
using AxWMPLib;
using System.Diagnostics.Eventing.Reader;

namespace Clock
{
    public partial class MainForm : Form
    {
        ColorDialog backgroundColorDialog; //можно было затащить из формы
        ColorDialog foregroundColorDialog;
        ChooseFont chooseFontDialog;
        AlarmList alarmList;
        Alarm alarm;
        string FontFile { get; set; }
        public MainForm()
        {
            InitializeComponent();
            AllocConsole();
            SetFontDirectory();
            this.TransparencyKey = Color.Empty;
            backgroundColorDialog = new ColorDialog();
            foregroundColorDialog = new ColorDialog();
            
            chooseFontDialog = new ChooseFont();
            LoadSettings();
            alarmList = new AlarmList();
            
            SetVisibility(false); // отображение только часов
            this.Location = new Point   // Локация появления часов
                (
                     System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - this.Width,
                     50  
                );   // this.Width - ширина формы (по X), 50-по координате У
            this.Text += $" Location: {this.Location.X}x{this.Location.Y}";
            
            alarm = new Alarm();
            GetNextAlarm();     //F9+F5
            //SaveAlarms();
            //axWindowsMediaPlayer1.playState.CompareTo += AxWindowsMediaPlayer1_PlayStateChange;

        }
        void SetFontDirectory()
        {
            string location = Assembly.GetEntryAssembly().Location; // получаем полный адрес исполн файла
            string path = Path.GetDirectoryName(location);         //из адреса извлекаем путь к файлу
            //MessageBox.Show(path);
            Directory.SetCurrentDirectory($"{path}\\..\\..\\Fonts"); // переходим в каталог со шрифтами
            //MessageBox.Show(Directory.GetCurrentDirectory());
        }
        void LoadSettings()
        {
            StreamReader sr = new StreamReader("settings.txt");
            List<string> settings = new List<string>();
            while (!sr.EndOfStream)
            {
                settings.Add(sr.ReadLine());
            }
            sr.Close();
            backgroundColorDialog.Color = Color.FromArgb(Convert.ToInt32(settings.ToArray()[0]));
            foregroundColorDialog.Color = Color.FromArgb(Convert.ToInt32(settings.ToArray()[1]));
            FontFile = settings.ToArray()[2];
            topmostToolStripMenuItem.Checked = bool.Parse(settings.ToArray()[3]);
            showDataToolStripMenuItem.Checked = bool.Parse(settings.ToArray()[4]);
            labeltime.Font = chooseFontDialog.SetFontFile(FontFile);
            labeltime.ForeColor = foregroundColorDialog.Color;
            labeltime.BackColor = backgroundColorDialog.Color;
               
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            Object run = rk.GetValue("Clock318");
            if (run != null) loadOnWindowsStarttupToolStripMenuItem.Checked = true;
            rk.Dispose();
        }
        void SaveSettings() //сохраняет настройки
        {
            StreamWriter sw = new StreamWriter("settings.txt");
            sw.WriteLine(backgroundColorDialog.Color.ToArgb()); //ToArgb() возвращает числовой код  цвета
            sw.WriteLine(foregroundColorDialog.Color.ToArgb()); //rgb - red,green,blue, a - альфаканал(канал прозрачности)
            sw.WriteLine(chooseFontDialog.FontFile.Split('\\').Last());
            sw.WriteLine(topmostToolStripMenuItem.Checked);
            sw.WriteLine(showDataToolStripMenuItem.Checked);
            sw.WriteLine(alarmsToolStripMenuItem.Checked);

            sw.Close();
            Process.Start("notepad","settings.txt");
        }
        void GetNextAlarm()
        {
            List<Alarm> alarms = new List<Alarm>();
            foreach (Alarm item in alarmList.ListBoxAlarms.Items)
            {
                if (item.Time.TimeOfDay > DateTime.Now.TimeOfDay) 
                    alarms.Add(item);
            }
            if (alarms.Min() != null) alarm = alarms.Min();
                /*if(DateTime.Now =new Dat)
                alarmList.ListBoxAlarms.Items.Clear();
                intervals.Add(item.Time - DateTime.Now.TimeOfDay); */
            Console.WriteLine(alarm);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            labeltime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            if (cbShowDate.Checked)
            {
                labeltime.Text += $"\n{DateTime.Today.ToString("yyyy.MM.dd")}";
            }
            if (showWeekdayToolStripMenuItem.Checked)
            {
                labeltime.Text += $"\n{DateTime.Today.DayOfWeek}";
            }
            //notifyIconSystemTray.BalloonTipText = "Current time" + labeltime.Text;
            //GetNextAlarm(); // выведение каждую секунду
            //if (alarm.Weekdays == ;
            //int weekday = (int)DateTime.Now.DayOfWeek;
            //weekday = weekday == 0 ? 7 : weekday - 1;
            if(
                    alarm !=null &&
                    alarm.Weekdays[((int)DateTime.Now.DayOfWeek == 0 ? 6 : (int)DateTime.Now.DayOfWeek - 1)] == true &&
                    /*DateTime.Now.DayOfWeek == DayOfWeek.Sunday &&*/
                    DateTime.Now.Hour == alarm.Time.Hour &&
                    DateTime.Now.Minute == alarm.Time.Minute &&
                    DateTime.Now.Second == alarm.Time.Second
                     )
                {
                    //MessageBox.Show(alarm.Filename, "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.WriteLine("ALARM:----" + alarm.ToString());                   
                    PlayAlarm();
                    GetNextAlarm();
                 }
            if (DateTime.Now.Second==0)
            {
                GetNextAlarm();
                Console.WriteLine("Minute");
            }
               
        }
        void PlayAlarm()
        {
            if (File.Exists(alarm.Filename))        // если файл существует то играем его.
            {
                axWindowsMediaPlayer.URL = alarm.Filename;  
            }
            else
            {
                PlayDefaultAlarmSound(); // вызов метода воспр по умолx
                return;                  // выход сразу иначе будут выполняться нижние строчки
            }
            //axWindowsMediaPlayer.URL = File.Exists(alarm.Filename) ? alarm.Filename : PlayDefaultAlarmSound();
            //File.Exists(alarm.Filename)? alarm.Filename: DEFAULT_ALARM_FILE_NAME;// ? alarm.Filename: "..\\Sound\\Король и Шут - Лесник.flac";  
            axWindowsMediaPlayer.settings.volume = 100;
            axWindowsMediaPlayer.Visible = true;
            axWindowsMediaPlayer.Ctlcontrols.play();
            //Console.WriteLine($"PlayAlarm:\t{Directory.GetCurrentDirectory()}");
              
            
        }
        private void PlayDefaultAlarmSound() // метод для воспр мелодии по умолчанию
        {
            string soundFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sound\\Король и Шут - Лесник.mp3");
            if (File.Exists(soundFilePath))
            {
                axWindowsMediaPlayer.URL = soundFilePath;
                axWindowsMediaPlayer.Ctlcontrols.play();
                MessageBox.Show("Выбранный трек не найден, звучит мелодия по умолчанию: Король и Шут - Лесник.mp3");
            }
            else

                MessageBox.Show("Файл мелодии не найден: " + soundFilePath);
        }
            
        private void SetVisibility(bool visible)
        {
            this.TransparencyKey = visible ? Color.Empty : this.BackColor; //обращение к объекту данной формы
            this.FormBorderStyle = visible ? FormBorderStyle.Sizable : FormBorderStyle.None; //форма элемента SIZABLE скрыть
            this.ShowInTaskbar = visible; //скрытие в панели задач
            cbShowDate.Visible = visible;
            btnHideControls.Visible = visible;
            labeltime.BackColor = visible ? Color.Empty : backgroundColorDialog.Color ; //изменение цвета
            axWindowsMediaPlayer.Visible = false; //ctrl+r+r заменить 
        }
        private void btnHideControls_Click(object sender, EventArgs e)
        {
            showControlsToolStripMenuItem.Checked = false;
            notifyIconSystemTray.ShowBalloonTip(3, "Alert!", "Для того чтобы вернуть как было, нужно ткнуть 2 раза мышкой по часам, или по этой иконке", ToolTipIcon.Info);  //обработка галочки на скрытие элементов
        }
        private void labeltime_DoubleClick(object sender, EventArgs e)
        {
            showControlsToolStripMenuItem.Checked = true;

        }
        private void notifyIconSystemTray_MouseMove(object sender, MouseEventArgs e)
        {
            notifyIconSystemTray.Text = "Current time:\n" + labeltime.Text;
        }

        private void ShowContextMenu_RightClick(object sender, MouseEventArgs e)
        {
            this.contextMenuStrip.Visible = true;
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
        private void showDataToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            cbShowDate.Checked = showDataToolStripMenuItem.Checked;
        }
        private void cbShowData_CheckedChanged(object sender, EventArgs e)
        {
            showDataToolStripMenuItem.Checked = cbShowDate.Checked; // 
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

        private void fonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chooseFontDialog.ShowDialog(this) == DialogResult.OK)
            {
                labeltime.Font = chooseFontDialog.ChosenFont;
            }
        }
        private void labeltime_MouseEnter(object sender, EventArgs e)
        {
            contextMenuStrip.ForeColor = Color.Black;
            labeltime.ForeColor = Color.Yellow;
        }
        private void labeltime_MouseLeave(object sender, EventArgs e)
        {
            contextMenuStrip.ForeColor = Color.Black;
            labeltime.ForeColor = foregroundColorDialog.Color;
        }
        Point lastPoint;
        private void labeltime_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labeltime_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
            alarmList.SaveAlarmsToFile("alarms.csv");
        }

        private void loadOnWindowsStarttupToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            RegistryKey rk =
                Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (loadOnWindowsStarttupToolStripMenuItem.Checked) rk.SetValue("Clock318", Application.ExecutablePath);
            else rk.DeleteValue("Clock318", false); //false - не бросать исключения если указанная запись отсутствует.
            rk.Dispose(); // Освобождает ресурсы освобождаемые объектом.

        }

        private void alarmsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alarmList.ShowDialog(this);
            GetNextAlarm();
        }
        void SetPlayerInvisible(object sender, _WMPOCXEvents_AudioLanguageChangeEventHandler e)
        {
            if(axWindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            axWindowsMediaPlayer.Visible = false;
        }
        void SetPlayerInvisible(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            axWindowsMediaPlayer.Visible = false;    
        }
        [DllImport("kernel32.dll")]
        static extern bool AllocConsole();

        /*private void AxWindowsMediaPlayer1_PlayStateChange(int newState)
        {
            if (newState == (int)WMPLib.WMPPlayState.wmppsStopped) { axWindowsMediaPlayer.Visible = false; }
        }*/
           
        private void restoreDefaultSettingsToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            contextMenuStrip.ForeColor = Color.Black; backgroundColorDialog.Color = Color.Black;
            labeltime.ForeColor = Color.White; foregroundColorDialog.Color = Color.White;
           // var defaultFont = new Font("Bloodlust3D", 12);
            //labeltime.Font = new Font("Bloodlust3D", 24);
            //chooseFontDialog.Font = new Font("Bloodlust3D", 24);
            //SaveSettings();

        }
    }
}
