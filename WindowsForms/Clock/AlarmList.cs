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
    public partial class AlarmList : Form
    {
        public AlarmList()
        {
            InitializeComponent();
        }
        

        private void buttonAddAlarm_Click(object sender, EventArgs e)
        {
            AddAlarmcs addAlarmcs = new AddAlarmcs();
            if (addAlarmcs.ShowDialog(this) == DialogResult.OK)
            {
                listBoxAlarm.Items.Add(addAlarmcs.Alarm);
            }
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
                //this.Refresh();
            }
        }
    }
}
