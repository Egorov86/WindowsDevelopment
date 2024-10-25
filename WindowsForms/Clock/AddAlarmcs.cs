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
        Alarm alarm;
        public AddAlarmcs()
        {
            InitializeComponent();
            alarm = new Alarm();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBoxFocusChar_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerDate.Enabled = ((CheckBox)sender).Checked;
        }
    }
}
