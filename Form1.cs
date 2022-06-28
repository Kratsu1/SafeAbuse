using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafeAbuse
{
    public partial class SafeAbuse : Form
    {
        private int standTime;
        private int sitTime;
        private int seconds = 60;
        private bool showAlert = true;

        public SafeAbuse()
        {
            InitializeComponent();
        }

        private void btnStopTimer_Click(object sender, EventArgs e)
        {
            StopTimers();
        }

        private void btnResetTimer_Click(object sender, EventArgs e)
        {
            StopTimers();
            StartTimers(1);

            seconds = 60;
            lblStand.Text = "Stand (00)";
            lblSit.Text = "Sit (00)";
        }

        private void StopTimers()
        {
            timerStand.Stop();
            timerSit.Stop();
            timerSeconds.Stop();
        }
        private void StartTimers(int identifier)
        {
            if (identifier == 1)
                timerStand.Start();
            else
                timerSit.Start();
            timerSeconds.Start();
        }

        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            lblStand.Text = "Stand (" + txtTimeStand.Text + ")";
            lblSit.Text = "Sit (" + txtTimeSit.Text + ")";
            StartTimers(1);
        }

        private void TimerStand_Tick(object sender, EventArgs e)
        {
            int.TryParse(lblStand.Text.Split('(')[1].Split(')')[0], out standTime);

            standTime--;
            lblStand.Text = "Stand (" + standTime + ")";

            if (standTime == 0)
            {
                lblStand.Text = "Stand (" + txtTimeStand.Text + ")";
                StopTimers();
                StartTimers(2);
            }
        }

        private void TimerSit_Tick(object sender, EventArgs e)
        {
            int.TryParse(lblSit.Text.Split('(')[1].Split(')')[0], out sitTime);

            sitTime--;

            if (sitTime == 0)
            {
                lblSit.Text = "Sit (" + txtTimeSit.Text + ")";
                StopTimers();
                StartTimers(1);
            }
        }

        private void TimerSeconds_Tick(object sender, EventArgs e)
        {
            lblSecondCounter.Text = seconds.ToString();
            if(seconds == 1)
            {
                seconds = 60;
            }
            seconds--;
        }

    }
}
