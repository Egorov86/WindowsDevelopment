﻿using System;
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
            addAlarmcs.ShowDialog(this);
        }
    }
}
