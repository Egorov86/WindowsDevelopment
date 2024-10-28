namespace Clock
{
    partial class AddAlarmcs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.checkedListBoxWeek = new System.Windows.Forms.CheckedListBox();
            this.labelFilename = new System.Windows.Forms.Label();
            this.buttonChooseFile = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.checkBoxFocusChar = new System.Windows.Forms.CheckBox();
            this.openFileDialogSound = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTime.Location = new System.Drawing.Point(228, 35);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.ShowUpDown = true;
            this.dateTimePickerTime.Size = new System.Drawing.Size(200, 44);
            this.dateTimePickerTime.TabIndex = 0;
            // 
            // checkedListBoxWeek
            // 
            this.checkedListBoxWeek.CheckOnClick = true;
            this.checkedListBoxWeek.ColumnWidth = 58;
            this.checkedListBoxWeek.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBoxWeek.FormattingEnabled = true;
            this.checkedListBoxWeek.Items.AddRange(new object[] {
            "Пн",
            "Вт",
            "Ср",
            "Чт",
            "Пт",
            "Суб",
            "Вс"});
            this.checkedListBoxWeek.Location = new System.Drawing.Point(12, 85);
            this.checkedListBoxWeek.MultiColumn = true;
            this.checkedListBoxWeek.Name = "checkedListBoxWeek";
            this.checkedListBoxWeek.Size = new System.Drawing.Size(416, 31);
            this.checkedListBoxWeek.TabIndex = 1;
            // 
            // labelFilename
            // 
            this.labelFilename.AutoSize = true;
            this.labelFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFilename.Location = new System.Drawing.Point(12, 119);
            this.labelFilename.Name = "labelFilename";
            this.labelFilename.Size = new System.Drawing.Size(59, 15);
            this.labelFilename.TabIndex = 2;
            this.labelFilename.Text = "Filename";
            this.labelFilename.TextChanged += new System.EventHandler(this.labelFilename_TextChanged);
            // 
            // buttonChooseFile
            // 
            this.buttonChooseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChooseFile.Location = new System.Drawing.Point(12, 141);
            this.buttonChooseFile.Name = "buttonChooseFile";
            this.buttonChooseFile.Size = new System.Drawing.Size(133, 33);
            this.buttonChooseFile.TabIndex = 3;
            this.buttonChooseFile.Text = "Выбрать файл";
            this.buttonChooseFile.UseVisualStyleBackColor = true;
            this.buttonChooseFile.TextChanged += new System.EventHandler(this.labelFilenameTextChanged);
            this.buttonChooseFile.Click += new System.EventHandler(this.buttonChooseFile_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Enabled = false;
            this.buttonOK.Location = new System.Drawing.Point(272, 151);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(353, 151);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Enabled = false;
            this.dateTimePickerDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Location = new System.Drawing.Point(12, 35);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 44);
            this.dateTimePickerDate.TabIndex = 0;
            // 
            // checkBoxFocusChar
            // 
            this.checkBoxFocusChar.AutoSize = true;
            this.checkBoxFocusChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxFocusChar.Location = new System.Drawing.Point(12, 5);
            this.checkBoxFocusChar.Name = "checkBoxFocusChar";
            this.checkBoxFocusChar.Size = new System.Drawing.Size(191, 24);
            this.checkBoxFocusChar.TabIndex = 5;
            this.checkBoxFocusChar.Text = "На конктретную дату";
            this.checkBoxFocusChar.UseVisualStyleBackColor = true;
            // 
            // openFileDialogSound
            // 
            this.openFileDialogSound.FileName = "openFileDialogSound";
            // 
            // AddAlarmcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 182);
            this.Controls.Add(this.checkBoxFocusChar);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonChooseFile);
            this.Controls.Add(this.labelFilename);
            this.Controls.Add(this.checkedListBoxWeek);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.dateTimePickerTime);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAlarmcs";
            this.Text = "AddAlarmcs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
        private System.Windows.Forms.CheckedListBox checkedListBoxWeek;
        private System.Windows.Forms.Label labelFilename;
        private System.Windows.Forms.Button buttonChooseFile;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.CheckBox checkBoxFocusChar;
        private System.Windows.Forms.OpenFileDialog openFileDialogSound;
    }
}