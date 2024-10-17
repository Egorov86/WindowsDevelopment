namespace Clock
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labeltime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbShowDate = new System.Windows.Forms.CheckBox();
            this.btnHideControls = new System.Windows.Forms.Button();
            this.notifyIconSystemTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.поверхВсехОконToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьЭлементыКправленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьДатуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выборЦветаЦветФонаЦветШрифтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбратьШрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запускатьПриСтартеWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labeltime
            // 
            this.labeltime.AutoSize = true;
            this.labeltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeltime.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labeltime.Location = new System.Drawing.Point(12, 9);
            this.labeltime.Name = "labeltime";
            this.labeltime.Size = new System.Drawing.Size(121, 52);
            this.labeltime.TabIndex = 0;
            this.labeltime.Text = "Time";
            this.labeltime.DoubleClick += new System.EventHandler(this.labeltime_DoubleClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbShowDate
            // 
            this.cbShowDate.AutoSize = true;
            this.cbShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbShowDate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbShowDate.Location = new System.Drawing.Point(5, 130);
            this.cbShowDate.Name = "cbShowDate";
            this.cbShowDate.Size = new System.Drawing.Size(243, 37);
            this.cbShowDate.TabIndex = 1;
            this.cbShowDate.Text = "Показать дату";
            this.cbShowDate.UseVisualStyleBackColor = true;
            // 
            // btnHideControls
            // 
            this.btnHideControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHideControls.Location = new System.Drawing.Point(17, 183);
            this.btnHideControls.Name = "btnHideControls";
            this.btnHideControls.Size = new System.Drawing.Size(238, 82);
            this.btnHideControls.TabIndex = 2;
            this.btnHideControls.Text = "Скрыть элементы управления";
            this.btnHideControls.UseVisualStyleBackColor = true;
            this.btnHideControls.Click += new System.EventHandler(this.btnHideControls_Click);
            // 
            // notifyIconSystemTray
            // 
            this.notifyIconSystemTray.BalloonTipTitle = "Current time";
            this.notifyIconSystemTray.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconSystemTray.Icon")));
            this.notifyIconSystemTray.Text = "notifyIcon1";
            this.notifyIconSystemTray.Visible = true;
            this.notifyIconSystemTray.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconSystemTray_MouseMove);
            this.notifyIconSystemTray.MouseMove += new System.Windows.Forms.MouseEventHandler(this.notifyIconSystemTray_MouseMove);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поверхВсехОконToolStripMenuItem,
            this.показатьЭлементыКправленияToolStripMenuItem,
            this.показатьДатуToolStripMenuItem,
            this.выборЦветаЦветФонаЦветШрифтаToolStripMenuItem,
            this.выбратьШрифтToolStripMenuItem,
            this.запускатьПриСтартеWindowsToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(305, 180);
           
            // 
            // поверхВсехОконToolStripMenuItem
            // 
            this.поверхВсехОконToolStripMenuItem.Name = "поверхВсехОконToolStripMenuItem";
            this.поверхВсехОконToolStripMenuItem.Size = new System.Drawing.Size(304, 22);
            this.поверхВсехОконToolStripMenuItem.Text = "-Поверх всех окон;";
            // 
            // показатьЭлементыКправленияToolStripMenuItem
            // 
            this.показатьЭлементыКправленияToolStripMenuItem.Name = "показатьЭлементыКправленияToolStripMenuItem";
            this.показатьЭлементыКправленияToolStripMenuItem.Size = new System.Drawing.Size(304, 22);
            this.показатьЭлементыКправленияToolStripMenuItem.Text = "-Показать элементы кправления;";
            // 
            // показатьДатуToolStripMenuItem
            // 
            this.показатьДатуToolStripMenuItem.Name = "показатьДатуToolStripMenuItem";
            this.показатьДатуToolStripMenuItem.Size = new System.Drawing.Size(304, 22);
            this.показатьДатуToolStripMenuItem.Text = "-Показать дату;";
            // 
            // выборЦветаЦветФонаЦветШрифтаToolStripMenuItem
            // 
            this.выборЦветаЦветФонаЦветШрифтаToolStripMenuItem.Name = "выборЦветаЦветФонаЦветШрифтаToolStripMenuItem";
            this.выборЦветаЦветФонаЦветШрифтаToolStripMenuItem.Size = new System.Drawing.Size(304, 22);
            this.выборЦветаЦветФонаЦветШрифтаToolStripMenuItem.Text = "-Выбор цвета > Цвет фона, Цвет шрифта;";
            // 
            // выбратьШрифтToolStripMenuItem
            // 
            this.выбратьШрифтToolStripMenuItem.Name = "выбратьШрифтToolStripMenuItem";
            this.выбратьШрифтToolStripMenuItem.Size = new System.Drawing.Size(304, 22);
            this.выбратьШрифтToolStripMenuItem.Text = "-Выбрать шрифт;";
            // 
            // запускатьПриСтартеWindowsToolStripMenuItem
            // 
            this.запускатьПриСтартеWindowsToolStripMenuItem.Name = "запускатьПриСтартеWindowsToolStripMenuItem";
            this.запускатьПриСтартеWindowsToolStripMenuItem.Size = new System.Drawing.Size(304, 22);
            this.запускатьПриСтартеWindowsToolStripMenuItem.Text = "-Запускать при старте Windows;";
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(304, 22);
            this.закрытьToolStripMenuItem.Text = "-Закрыть;";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(266, 277);
            this.Controls.Add(this.btnHideControls);
            this.Controls.Add(this.cbShowDate);
            this.Controls.Add(this.labeltime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1620, 20);
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Clock";
            this.TransparencyKey = System.Drawing.Color.White;
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeltime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox cbShowDate;
        private System.Windows.Forms.Button btnHideControls;
        private System.Windows.Forms.NotifyIcon notifyIconSystemTray;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поверхВсехОконToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьЭлементыКправленияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьДатуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выборЦветаЦветФонаЦветШрифтаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбратьШрифтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запускатьПриСтартеWindowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
    }
}

