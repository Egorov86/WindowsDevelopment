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
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.topmostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.showDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foregraundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgraundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.loadOnWindowsStarttupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbShowDate = new System.Windows.Forms.CheckBox();
            this.btnHideControls = new System.Windows.Forms.Button();
            this.notifyIconSystemTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.alarmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // labeltime
            // 
            this.labeltime.AutoSize = true;
            this.labeltime.ContextMenuStrip = this.contextMenuStrip;
            this.labeltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeltime.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labeltime.Location = new System.Drawing.Point(12, 9);
            this.labeltime.Name = "labeltime";
            this.labeltime.Size = new System.Drawing.Size(121, 52);
            this.labeltime.TabIndex = 0;
            this.labeltime.Text = "Time";
            this.labeltime.DoubleClick += new System.EventHandler(this.labeltime_DoubleClick);
            this.labeltime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labeltime_MouseDown);
            this.labeltime.MouseEnter += new System.EventHandler(this.labeltime_MouseEnter);
            this.labeltime.MouseLeave += new System.EventHandler(this.labeltime_MouseLeave);
            this.labeltime.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labeltime_MouseMove);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topmostToolStripMenuItem,
            this.showControlsToolStripMenuItem,
            this.toolStripSeparator4,
            this.showDataToolStripMenuItem,
            this.toolStripSeparator5,
            this.colorsToolStripMenuItem,
            this.fonsToolStripMenuItem,
            this.toolStripSeparator1,
            this.alarmsToolStripMenuItem,
            this.toolStripSeparator2,
            this.loadOnWindowsStarttupToolStripMenuItem,
            this.toolStripSeparator3,
            this.closeToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(239, 232);
            // 
            // topmostToolStripMenuItem
            // 
            this.topmostToolStripMenuItem.CheckOnClick = true;
            this.topmostToolStripMenuItem.Name = "topmostToolStripMenuItem";
            this.topmostToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.topmostToolStripMenuItem.Text = "Topmost";
            this.topmostToolStripMenuItem.CheckedChanged += new System.EventHandler(this.topmostToolStripMenuItem_CheckedChanged);
            // 
            // showControlsToolStripMenuItem
            // 
            this.showControlsToolStripMenuItem.CheckOnClick = true;
            this.showControlsToolStripMenuItem.Name = "showControlsToolStripMenuItem";
            this.showControlsToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.showControlsToolStripMenuItem.Text = "Show controls";
            this.showControlsToolStripMenuItem.CheckedChanged += new System.EventHandler(this.showControlsToolStripMenuItem_CheckedChanged);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(235, 6);
            // 
            // showDataToolStripMenuItem
            // 
            this.showDataToolStripMenuItem.CheckOnClick = true;
            this.showDataToolStripMenuItem.Name = "showDataToolStripMenuItem";
            this.showDataToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.showDataToolStripMenuItem.Text = "Show data";
            this.showDataToolStripMenuItem.CheckedChanged += new System.EventHandler(this.showDataToolStripMenuItem_CheckedChanged);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(235, 6);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foregraundColorToolStripMenuItem,
            this.backgraundColorToolStripMenuItem});
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.colorsToolStripMenuItem.Text = "Colors";
            // 
            // foregraundColorToolStripMenuItem
            // 
            this.foregraundColorToolStripMenuItem.Name = "foregraundColorToolStripMenuItem";
            this.foregraundColorToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.foregraundColorToolStripMenuItem.Text = "Foreground color";
            this.foregraundColorToolStripMenuItem.Click += new System.EventHandler(this.foregraundColorToolStripMenuItem_Click);
            // 
            // backgraundColorToolStripMenuItem
            // 
            this.backgraundColorToolStripMenuItem.Name = "backgraundColorToolStripMenuItem";
            this.backgraundColorToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.backgraundColorToolStripMenuItem.Text = "Background color";
            this.backgraundColorToolStripMenuItem.Click += new System.EventHandler(this.backgraundColorToolStripMenuItem_Click);
            // 
            // fonsToolStripMenuItem
            // 
            this.fonsToolStripMenuItem.Name = "fonsToolStripMenuItem";
            this.fonsToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.fonsToolStripMenuItem.Text = "Fons";
            this.fonsToolStripMenuItem.Click += new System.EventHandler(this.fonsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(235, 6);
            // 
            // loadOnWindowsStarttupToolStripMenuItem
            // 
            this.loadOnWindowsStarttupToolStripMenuItem.CheckOnClick = true;
            this.loadOnWindowsStarttupToolStripMenuItem.Name = "loadOnWindowsStarttupToolStripMenuItem";
            this.loadOnWindowsStarttupToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.loadOnWindowsStarttupToolStripMenuItem.Text = "Load onWindows starttup";
            this.loadOnWindowsStarttupToolStripMenuItem.CheckedChanged += new System.EventHandler(this.loadOnWindowsStarttupToolStripMenuItem_CheckedChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(235, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
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
            this.cbShowDate.CheckedChanged += new System.EventHandler(this.cbShowData_CheckedChanged);
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
            this.notifyIconSystemTray.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIconSystemTray.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconSystemTray.Icon")));
            this.notifyIconSystemTray.Text = "notifyIcon1";
            this.notifyIconSystemTray.Visible = true;
            this.notifyIconSystemTray.DoubleClick += new System.EventHandler(this.notifyIconSystemTray_DoubleClick);
            this.notifyIconSystemTray.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconSystemTray_MouseMove);
            this.notifyIconSystemTray.MouseMove += new System.Windows.Forms.MouseEventHandler(this.notifyIconSystemTray_MouseMove);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(235, 6);
            // 
            // alarmsToolStripMenuItem
            // 
            this.alarmsToolStripMenuItem.Name = "alarmsToolStripMenuItem";
            this.alarmsToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.alarmsToolStripMenuItem.Text = "Alarms";
            this.alarmsToolStripMenuItem.Click += new System.EventHandler(this.alarmsToolStripMenuItem_Click);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeltime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox cbShowDate;
        private System.Windows.Forms.Button btnHideControls;
        private System.Windows.Forms.NotifyIcon notifyIconSystemTray;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem topmostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showControlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem showDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem loadOnWindowsStarttupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem foregraundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgraundColorToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ToolStripMenuItem alarmsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

