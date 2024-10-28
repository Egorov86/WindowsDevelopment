namespace Clock
{
    partial class AlarmList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmList));
            this.listBoxAlarm = new System.Windows.Forms.ListBox();
            this.buttonAddAlarm = new System.Windows.Forms.Button();
            this.buttonDeleteAlarm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxAlarm
            // 
            this.listBoxAlarm.FormattingEnabled = true;
            this.listBoxAlarm.Location = new System.Drawing.Point(13, 25);
            this.listBoxAlarm.Name = "listBoxAlarm";
            this.listBoxAlarm.Size = new System.Drawing.Size(270, 147);
            this.listBoxAlarm.TabIndex = 0;
            // 
            // buttonAddAlarm
            // 
            this.buttonAddAlarm.Location = new System.Drawing.Point(289, 25);
            this.buttonAddAlarm.Name = "buttonAddAlarm";
            this.buttonAddAlarm.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAlarm.TabIndex = 1;
            this.buttonAddAlarm.Text = "Добавить";
            this.buttonAddAlarm.UseVisualStyleBackColor = true;
            this.buttonAddAlarm.Click += new System.EventHandler(this.buttonAddAlarm_Click);
            // 
            // buttonDeleteAlarm
            // 
            this.buttonDeleteAlarm.Location = new System.Drawing.Point(289, 54);
            this.buttonDeleteAlarm.Name = "buttonDeleteAlarm";
            this.buttonDeleteAlarm.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteAlarm.TabIndex = 1;
            this.buttonDeleteAlarm.Text = "Удалить";
            this.buttonDeleteAlarm.UseVisualStyleBackColor = true;
            // 
            // AlarmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(371, 185);
            this.Controls.Add(this.buttonDeleteAlarm);
            this.Controls.Add(this.buttonAddAlarm);
            this.Controls.Add(this.listBoxAlarm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlarmList";
            this.Text = "AlarmList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAlarm;
        private System.Windows.Forms.Button buttonAddAlarm;
        private System.Windows.Forms.Button buttonDeleteAlarm;
    }
}