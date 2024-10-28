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
    public partial class AddAlarmcs : Form
    {
        public Alarm Alarm { get; set; }
        public AddAlarmcs()
        {
            InitializeComponent();
            Alarm = new Alarm();
            //labelFilename.SetBounds(labelFilename.Location.X, labelFilename.Location.Y, this.Width - 10, 25);
            labelFilename.MaximumSize = new Size(this.Width - 25, 75);
            openFileDialogSound.Filter = "MP-3 (*.mp3)|*.mp3|Flac (*.flac)|*.flac|All Audio|*.mp3;*.flac";
        }
        void InitAlarm()
        {
            Alarm.Date = dateTimePickerDate.Enabled ? dateTimePickerDate.Value : DateTime.MinValue;
            Alarm.Time = dateTimePickerTime.Value;
            //Alarm.Time.Millisecond = 0;
            Alarm.Filename = labelFilename.Text;
            for (int i = 0; i < checkedListBoxWeek.CheckedIndices.Count; i++)
            {   //свойство "CheckedIndices" это коллекция которая содержит индексы выбранных галочек в сheckedListBox.
                //Alarm.Weekdays[i] = (checkedListBoxWeek.Items[i] as CheckBox).Checked;
                Alarm.Weekdays[checkedListBoxWeek.CheckedIndices[i]] = true;
                Console.Write(checkedListBoxWeek.CheckedIndices[i] + "\t");
            }
            if (Alarm.Filename == "Filename:")
            {
                MessageBox.Show("Выберите файл", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            Console.WriteLine();

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            InitAlarm();
        }

        private void checkBoxExactDate_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerDate.Enabled = ((CheckBox)sender).Checked;
        }

        private void AddAlarmcs_TextChanged(object sender, EventArgs e)
        {

        }


        private void labelFilenameTextChanged(object sender, EventArgs e)
        {
            buttonOK.Enabled = true;
        }

        private void buttonChooseFile_Click(object sender, EventArgs e)
        {
            if (openFileDialogSound.ShowDialog(this) == DialogResult.OK)
            {
                Alarm.Filename = labelFilename.Text = openFileDialogSound.FileName;
            }
        }

        private void labelFilename_TextChanged(object sender, EventArgs e)
        {
            buttonOK.Enabled = true;
        }
    }
}
