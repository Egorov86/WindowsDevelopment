using Clock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Clock
{
    public partial class AlarmList : Form
    {
        public ListBox ListBoxAlarms 
        {
            get => listBoxAlarm;
            private set => listBoxAlarm = value; 
        }
        public AlarmList()
        {
            InitializeComponent();
            LoadAlarms();
        }
        

        private void buttonAddAlarm_Click(object sender, EventArgs e)
        {
            AddAlarmcs addAlarmcs = new AddAlarmcs();
            if (addAlarmcs.ShowDialog(this) == DialogResult.OK)
            {
                listBoxAlarm.Items.Add(addAlarmcs.Alarm);
            }
            SaveAlarms(); // Сохраняем будильники после добавления нового
        }

        /*private void listBoxAlarm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            AddAlarmcs addAlarmcs = new AddAlarmcs();
            addAlarmcs.ShowDialog();
        }*/

        private void listBoxAlarm_DoubleClick(object sender, EventArgs e)
        {
            AddAlarmcs addAlarmcs = new AddAlarmcs((sender as ListBox).SelectedItem as Alarm);
            if (addAlarmcs.ShowDialog(this) == DialogResult.OK)
            {
                listBoxAlarm.SelectedItem = addAlarmcs.Alarm;
                listBoxAlarm.Items[listBoxAlarm.SelectedIndex] = listBoxAlarm.Items[listBoxAlarm.SelectedIndex];
                SaveAlarms();
                //this.Refresh();
            }
        }
        //private const string AlarmFilePath = "settings.txt"; //путь для сохранения будильника
        private void LoadAlarms()
        {
            if (!File.Exists("alarms.txt"))
            {
                MessageBox.Show("Файл будильников не найден. Будет создан новый.");
                return; //выход если файл не существует
            }
            try
            {
                using (StreamReader sr = new StreamReader("alarms.txt"))
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] parts = line.Split(';');
                    }
            }
            catch { }
        }
        private void SaveAlarms()
        {
            StreamWriter sw = new StreamWriter("alarms.txt");
            sw.WriteLine(AlarmList.ActiveForm);
            sw.Close(); 
           // writer.WriteLine("alarm.Time;alarm.IsActive");
           //sw.Close();
            //Process.Start("notepad", "alarm.txt");
            Process.Start("notepad","alarms.txt");

        }

    }
}
