using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ShutdownTimer
{
    public partial class Form1 : Form
    {
        private DateTime ClockwiseStart;
        private DateTime TimerwiseStart;
        private DateTime now = DateTime.Now;
        public int incre = 72;

        public Form1()
        {
            InitializeComponent();
        }


        private void ShutdownStart_CheckedChanged(object sender)
        {
            Properties.Settings.Default.valueTimer = sliderTimerShutdown.Value;
            Properties.Settings.Default.radioTimer = rdTimer.Checked;
            Properties.Settings.Default.radioClock = rdClock.Checked;
            Properties.Settings.Default.Save();
            if (ShutdownStart.Checked)
            {
                if(rdClock.Checked)
                {
                    ClockwiseStart = Convert.ToDateTime(cmbClockwise.SelectedItem);
                    TimeSpan timeSpan;
                    timeSpan = ClockwiseStart.Subtract(now);

                    string command = "/C shutdown -s -t " + (int)timeSpan.TotalSeconds + "";
                    Process.Start("cmd.exe", command);

                }
                else
                if(rdTimer.Checked)
                {
                    Int64 shutdowntimervalue = sliderTimerShutdown.Value * 60;
                    string command = "/C shutdown -s -t "+shutdowntimervalue+"";
                    Process.Start("cmd.exe", command);
                   
                    TimerwiseStart = now;
                    TimerwiseStart = TimerwiseStart.AddMinutes(sliderTimerShutdown.Value);
                
                }
                else
                {
                    MessageBox.Show("Kein Timer ausgewählt!");
                }
            }
            else
            {
                string command = "/C shutdown -a";
                Process.Start("cmd.exe", command);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;

            int x = 0;
            int y = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            this.Location = new System.Drawing.Point(x, y);
        
            sliderTimerShutdown.Value = Properties.Settings.Default.valueTimer;
            rdTimer.Checked = Properties.Settings.Default.radioTimer;
            rdClock.Checked =  Properties.Settings.Default.radioClock;

            DateTime cmbClock = DateTime.Now;
            DateTime nowAddetMinutes = DateTime.Now.AddHours(incre);

            while (cmbClock < nowAddetMinutes)
            {
                cmbClock = cmbClock.AddMinutes(1);
                cmbClockwise.Items.Add(cmbClock);
            }
            cmbClockwise.SelectedIndex = 0;
        

        }

        private void spaceQuest1_Click(object sender, EventArgs e)
        {
            CopyrightNoti.Visible = true;
            notifi.Start();

        }
        int Sekunden;
        private void notifi_Tick(object sender, EventArgs e)
        {
            Sekunden++;
            if(Sekunden >=5)
            {
                CopyrightNoti.Visible = false;
                Sekunden = 0;
                notifi.Stop();
            }
        }

        private void CopyrightNoti_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/MG937dTPAv");
        }

        private void foreverLabel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/MG937dTPAv");
        }

     
    }
}

