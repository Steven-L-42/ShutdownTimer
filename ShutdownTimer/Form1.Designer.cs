namespace ShutdownTimer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.spaceForm1 = new ReaLTaiizor.Forms.SpaceForm();
            this.foreverLabel2 = new ReaLTaiizor.Controls.ForeverLabel();
            this.CopyrightNoti = new ReaLTaiizor.Controls.ForeverNotification();
            this.rdClock = new ReaLTaiizor.Controls.ForeverRadioButton();
            this.rdTimer = new ReaLTaiizor.Controls.ForeverRadioButton();
            this.cmbClockwise = new ReaLTaiizor.Controls.ForeverComboBox();
            this.parrotClock1 = new ReaLTaiizor.Controls.ParrotClock();
            this.ShutdownStart = new ReaLTaiizor.Controls.ForeverToggle();
            this.sliderTimerShutdown = new ReaLTaiizor.Controls.ForeverTrackBar();
            this.spaceLabel2 = new ReaLTaiizor.Controls.SpaceLabel();
            this.spaceMinimize1 = new ReaLTaiizor.Controls.SpaceMinimize();
            this.spaceQuest1 = new ReaLTaiizor.Controls.SpaceQuest();
            this.spaceLabel1 = new ReaLTaiizor.Controls.SpaceLabel();
            this.spaceClose1 = new ReaLTaiizor.Controls.SpaceClose();
            this.notifi = new System.Windows.Forms.Timer(this.components);
            this.spaceForm1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spaceForm1
            // 
            this.spaceForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.spaceForm1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.spaceForm1.Controls.Add(this.foreverLabel2);
            this.spaceForm1.Controls.Add(this.CopyrightNoti);
            this.spaceForm1.Controls.Add(this.rdClock);
            this.spaceForm1.Controls.Add(this.rdTimer);
            this.spaceForm1.Controls.Add(this.cmbClockwise);
            this.spaceForm1.Controls.Add(this.parrotClock1);
            this.spaceForm1.Controls.Add(this.ShutdownStart);
            this.spaceForm1.Controls.Add(this.sliderTimerShutdown);
            this.spaceForm1.Controls.Add(this.spaceLabel2);
            this.spaceForm1.Controls.Add(this.spaceMinimize1);
            this.spaceForm1.Controls.Add(this.spaceQuest1);
            this.spaceForm1.Controls.Add(this.spaceLabel1);
            this.spaceForm1.Controls.Add(this.spaceClose1);
            this.spaceForm1.Customization = "Kioq/yAgIP8qKir/Kioq/xwcHP/+/v7/Kysr/xkZGf8=";
            this.spaceForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spaceForm1.Font = new System.Drawing.Font("Verdana", 8F);
            this.spaceForm1.Image = null;
            this.spaceForm1.Location = new System.Drawing.Point(0, 0);
            this.spaceForm1.MaximumSize = new System.Drawing.Size(409, 217);
            this.spaceForm1.MinimumSize = new System.Drawing.Size(409, 217);
            this.spaceForm1.Movable = true;
            this.spaceForm1.Name = "spaceForm1";
            this.spaceForm1.NoRounding = false;
            this.spaceForm1.Padding = new System.Windows.Forms.Padding(5, 25, 5, 5);
            this.spaceForm1.Sizable = false;
            this.spaceForm1.Size = new System.Drawing.Size(409, 217);
            this.spaceForm1.SmartBounds = true;
            this.spaceForm1.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.spaceForm1.TabIndex = 0;
            this.spaceForm1.Text = "Shutdown-Timer";
            this.spaceForm1.TransparencyKey = System.Drawing.Color.Purple;
            this.spaceForm1.Transparent = false;
            // 
            // foreverLabel2
            // 
            this.foreverLabel2.AutoSize = true;
            this.foreverLabel2.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.foreverLabel2.ForeColor = System.Drawing.Color.LightGray;
            this.foreverLabel2.Location = new System.Drawing.Point(8, 197);
            this.foreverLabel2.Name = "foreverLabel2";
            this.foreverLabel2.Size = new System.Drawing.Size(87, 13);
            this.foreverLabel2.TabIndex = 26;
            this.foreverLabel2.Text = "by ShiiikK#1048";
            this.foreverLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CopyrightNoti
            // 
            this.CopyrightNoti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.CopyrightNoti.Close = false;
            this.CopyrightNoti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CopyrightNoti.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CopyrightNoti.Kind = ReaLTaiizor.Controls.ForeverNotification._Kind.Info;
            this.CopyrightNoti.Location = new System.Drawing.Point(192, 28);
            this.CopyrightNoti.Name = "CopyrightNoti";
            this.CopyrightNoti.Size = new System.Drawing.Size(215, 42);
            this.CopyrightNoti.TabIndex = 25;
            this.CopyrightNoti.Text = "Copyright by © ShiiikK";
            this.CopyrightNoti.Visible = false;
            this.CopyrightNoti.Click += new System.EventHandler(this.CopyrightNoti_Click);
            // 
            // rdClock
            // 
            this.rdClock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.rdClock.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.rdClock.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.rdClock.Checked = false;
            this.rdClock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdClock.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdClock.ForeColor = System.Drawing.Color.GhostWhite;
            this.rdClock.Location = new System.Drawing.Point(239, 156);
            this.rdClock.Name = "rdClock";
            this.rdClock.Options = ReaLTaiizor.Controls.ForeverRadioButton._Options.Style1;
            this.rdClock.Size = new System.Drawing.Size(69, 22);
            this.rdClock.TabIndex = 23;
            this.rdClock.Text = "Clock";
            // 
            // rdTimer
            // 
            this.rdTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.rdTimer.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.rdTimer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.rdTimer.Checked = true;
            this.rdTimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdTimer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdTimer.ForeColor = System.Drawing.Color.GhostWhite;
            this.rdTimer.Location = new System.Drawing.Point(239, 78);
            this.rdTimer.Name = "rdTimer";
            this.rdTimer.Options = ReaLTaiizor.Controls.ForeverRadioButton._Options.Style1;
            this.rdTimer.Size = new System.Drawing.Size(69, 22);
            this.rdTimer.TabIndex = 22;
            this.rdTimer.Text = "Timer";
            // 
            // cmbClockwise
            // 
            this.cmbClockwise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmbClockwise.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.cmbClockwise.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmbClockwise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbClockwise.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbClockwise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClockwise.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClockwise.ForeColor = System.Drawing.Color.White;
            this.cmbClockwise.FormattingEnabled = true;
            this.cmbClockwise.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmbClockwise.HoverFontColor = System.Drawing.Color.GhostWhite;
            this.cmbClockwise.ItemHeight = 18;
            this.cmbClockwise.Location = new System.Drawing.Point(24, 154);
            this.cmbClockwise.Name = "cmbClockwise";
            this.cmbClockwise.Size = new System.Drawing.Size(209, 24);
            this.cmbClockwise.TabIndex = 17;
            // 
            // parrotClock1
            // 
            this.parrotClock1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.parrotClock1.CircleThickness = 6;
            this.parrotClock1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.parrotClock1.DisplayFormat = ReaLTaiizor.Controls.ParrotClock.HourFormat.TwentyFourHour;
            this.parrotClock1.FilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.parrotClock1.FilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.parrotClock1.FilledSecondColor = System.Drawing.Color.DarkOrchid;
            this.parrotClock1.Font = new System.Drawing.Font("Impact", 15F);
            this.parrotClock1.HexagonColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.parrotClock1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.parrotClock1.Location = new System.Drawing.Point(321, 30);
            this.parrotClock1.Name = "parrotClock1";
            this.parrotClock1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.parrotClock1.ShowAmPm = false;
            this.parrotClock1.ShowHexagon = false;
            this.parrotClock1.ShowMinutesCircle = false;
            this.parrotClock1.ShowSecondsCircle = false;
            this.parrotClock1.Size = new System.Drawing.Size(83, 83);
            this.parrotClock1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.parrotClock1.TabIndex = 13;
            this.parrotClock1.Text = "parrotClock1";
            this.parrotClock1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotClock1.TimeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.parrotClock1.UnfilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.parrotClock1.UnfilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.parrotClock1.UnfilledSecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            // 
            // ShutdownStart
            // 
            this.ShutdownStart.BackColor = System.Drawing.Color.Transparent;
            this.ShutdownStart.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.ShutdownStart.BaseColorRed = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.ShutdownStart.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.ShutdownStart.Checked = false;
            this.ShutdownStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShutdownStart.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ShutdownStart.ForeColor = System.Drawing.Color.LightGray;
            this.ShutdownStart.Location = new System.Drawing.Point(321, 173);
            this.ShutdownStart.Name = "ShutdownStart";
            this.ShutdownStart.Options = ReaLTaiizor.Controls.ForeverToggle._Options.Style3;
            this.ShutdownStart.Size = new System.Drawing.Size(76, 33);
            this.ShutdownStart.TabIndex = 11;
            this.ShutdownStart.TextColor = System.Drawing.Color.LightGray;
            this.ShutdownStart.ToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ShutdownStart.CheckedChanged += new ReaLTaiizor.Controls.ForeverToggle.CheckedChangedEventHandler(this.ShutdownStart_CheckedChanged);
            // 
            // sliderTimerShutdown
            // 
            this.sliderTimerShutdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.sliderTimerShutdown.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.sliderTimerShutdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sliderTimerShutdown.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.sliderTimerShutdown.ForeColor = System.Drawing.Color.White;
            this.sliderTimerShutdown.HatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.sliderTimerShutdown.Location = new System.Drawing.Point(24, 78);
            this.sliderTimerShutdown.Maximum = 240;
            this.sliderTimerShutdown.Minimum = 0;
            this.sliderTimerShutdown.Name = "sliderTimerShutdown";
            this.sliderTimerShutdown.ShowValue = true;
            this.sliderTimerShutdown.Size = new System.Drawing.Size(209, 23);
            this.sliderTimerShutdown.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.sliderTimerShutdown.Style = ReaLTaiizor.Controls.ForeverTrackBar._Style.Slider;
            this.sliderTimerShutdown.TabIndex = 10;
            this.sliderTimerShutdown.Text = "foreverTrackBar1";
            this.sliderTimerShutdown.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.sliderTimerShutdown.Value = 30;
            // 
            // spaceLabel2
            // 
            this.spaceLabel2.Customization = "/v7+/yoqKv8=";
            this.spaceLabel2.Font = new System.Drawing.Font("Verdana", 8F);
            this.spaceLabel2.Image = null;
            this.spaceLabel2.Location = new System.Drawing.Point(53, 121);
            this.spaceLabel2.Name = "spaceLabel2";
            this.spaceLabel2.NoRounding = false;
            this.spaceLabel2.Size = new System.Drawing.Size(75, 27);
            this.spaceLabel2.TabIndex = 8;
            this.spaceLabel2.Text = "Clockwise";
            this.spaceLabel2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.spaceLabel2.Transparent = false;
            // 
            // spaceMinimize1
            // 
            this.spaceMinimize1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spaceMinimize1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spaceMinimize1.Customization = "G4qM/3LEtP8yMjL/Kioq/yPJzP8bioz//v7+/yMjI/8qKir/";
            this.spaceMinimize1.DefaultAnchor = true;
            this.spaceMinimize1.DefaultLocation = true;
            this.spaceMinimize1.Font = new System.Drawing.Font("Verdana", 8F);
            this.spaceMinimize1.Image = null;
            this.spaceMinimize1.Location = new System.Drawing.Point(335, 3);
            this.spaceMinimize1.Name = "spaceMinimize1";
            this.spaceMinimize1.NoRounding = false;
            this.spaceMinimize1.Size = new System.Drawing.Size(23, 21);
            this.spaceMinimize1.TabIndex = 7;
            this.spaceMinimize1.Text = "_";
            this.spaceMinimize1.Transparent = false;
            this.spaceMinimize1.WindowState = System.Windows.Forms.FormWindowState.Normal;
            // 
            // spaceQuest1
            // 
            this.spaceQuest1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spaceQuest1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spaceQuest1.Customization = "G4qM/3LEtP8yMjL/Kioq/yPJzP8bioz//v7+/yMjI/8qKir/";
            this.spaceQuest1.DefaultAnchor = true;
            this.spaceQuest1.DefaultLocation = true;
            this.spaceQuest1.Font = new System.Drawing.Font("Verdana", 8F);
            this.spaceQuest1.Image = null;
            this.spaceQuest1.Location = new System.Drawing.Point(311, 3);
            this.spaceQuest1.Name = "spaceQuest1";
            this.spaceQuest1.NoRounding = false;
            this.spaceQuest1.Size = new System.Drawing.Size(23, 21);
            this.spaceQuest1.TabIndex = 2;
            this.spaceQuest1.Text = "?";
            this.spaceQuest1.Transparent = false;
            this.spaceQuest1.Click += new System.EventHandler(this.spaceQuest1_Click);
            // 
            // spaceLabel1
            // 
            this.spaceLabel1.Customization = "/v7+/yoqKv8=";
            this.spaceLabel1.Font = new System.Drawing.Font("Verdana", 8F);
            this.spaceLabel1.Image = null;
            this.spaceLabel1.Location = new System.Drawing.Point(53, 45);
            this.spaceLabel1.Name = "spaceLabel1";
            this.spaceLabel1.NoRounding = false;
            this.spaceLabel1.Size = new System.Drawing.Size(56, 27);
            this.spaceLabel1.TabIndex = 1;
            this.spaceLabel1.Text = "Timer";
            this.spaceLabel1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.spaceLabel1.Transparent = false;
            // 
            // spaceClose1
            // 
            this.spaceClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spaceClose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spaceClose1.Customization = "DQ/S/xhh8/8yMjL/Kioq/x5/9/8ND9L//v7+/yMjI/8qKir/";
            this.spaceClose1.DefaultAnchor = true;
            this.spaceClose1.DefaultLocation = true;
            this.spaceClose1.Font = new System.Drawing.Font("Verdana", 8F);
            this.spaceClose1.Image = null;
            this.spaceClose1.Location = new System.Drawing.Point(383, 3);
            this.spaceClose1.Name = "spaceClose1";
            this.spaceClose1.NoRounding = false;
            this.spaceClose1.Size = new System.Drawing.Size(23, 21);
            this.spaceClose1.TabIndex = 0;
            this.spaceClose1.Text = "x";
            this.spaceClose1.Transparent = false;
            // 
            // notifi
            // 
            this.notifi.Interval = 1000;
            this.notifi.Tick += new System.EventHandler(this.notifi_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(409, 217);
            this.Controls.Add(this.spaceForm1);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.GhostWhite;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(409, 217);
            this.MinimumSize = new System.Drawing.Size(409, 217);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Purple;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.spaceForm1.ResumeLayout(false);
            this.spaceForm1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.SpaceForm spaceForm1;
        private ReaLTaiizor.Controls.SpaceClose spaceClose1;
        private ReaLTaiizor.Controls.SpaceQuest spaceQuest1;
        private ReaLTaiizor.Controls.ForeverToggle ShutdownStart;
        private ReaLTaiizor.Controls.ForeverTrackBar sliderTimerShutdown;
        private ReaLTaiizor.Controls.SpaceMinimize spaceMinimize1;
        private ReaLTaiizor.Controls.ParrotClock parrotClock1;
        private ReaLTaiizor.Controls.ForeverComboBox cmbClockwise;
        private ReaLTaiizor.Controls.ForeverRadioButton rdTimer;
        private ReaLTaiizor.Controls.ForeverRadioButton rdClock;
        private ReaLTaiizor.Controls.SpaceLabel spaceLabel2;
        private ReaLTaiizor.Controls.SpaceLabel spaceLabel1;
        private ReaLTaiizor.Controls.ForeverNotification CopyrightNoti;
        private System.Windows.Forms.Timer notifi;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel2;
    }
}

