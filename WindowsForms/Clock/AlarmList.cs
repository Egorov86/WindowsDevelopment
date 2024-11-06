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
using System.IO;
using System.Diagnostics;

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
            LoadAlarmsToFile("alarms.csv");
        }
        

        private void buttonAddAlarm_Click(object sender, EventArgs e)
        {
            AddAlarmcs addAlarmcs = new AddAlarmcs();
            if (addAlarmcs.ShowDialog(this) == DialogResult.OK)
            {
                listBoxAlarm.Items.Add(addAlarmcs.Alarm);
            }
            //SaveAlarmsToFile(); // Сохраняем будильники после добавления нового
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
                //SaveAlarmsToFile();
                //this.Refresh();
            }
        }
        //private const string AlarmFilePath = "settings.txt"; //путь для сохранения будильника
        
        /*{
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
        }*/
        public void SaveAlarmsToFile(string filename)
        {
            StreamWriter sw = new StreamWriter(filename);          
            foreach (Alarm alarm in listBoxAlarm.Items)
            {
                sw.WriteLine(alarm.ToFileString());
            }
            sw.Close(); 
           // writer.WriteLine("alarm.Time;alarm.IsActive");
           //sw.Close();
            //Process.Start("notepad", "alarm.txt");
            Process.Start("notepad", filename);

        }
        public void LoadAlarmsToFile(string filename)
        {
            try
            {
                StreamReader sr = new StreamReader(filename);
                while (!sr.EndOfStream)
                {
                    string alarm = sr.ReadLine();
                    listBoxAlarm.Items.Add(new Alarm(alarm));
                }
                sr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Alarm warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void buttonDeleteAlarm_Click(object sender, EventArgs e) //кнопка удалить на будильнике
        {
            listBoxAlarm.Items.Remove(listBoxAlarm.SelectedItem);
        }
    }
}
