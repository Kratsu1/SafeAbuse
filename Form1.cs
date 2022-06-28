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
        private int seconds = 59;

        public SafeAbuse()
        {
            InitializeComponent();
        }

        private void btnStopTimer_Click(object sender, EventArgs e)
        {
            StopTimers();
        }
        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            lblStand.Text = "Stand (" + txtTimeStand.Text + ")";
            lblSit.Text = "Sit (" + txtTimeSit.Text + ")";
            StartTimers(1);
        }
        private void btnOkayStandUp_Click(object sender, EventArgs e)
        {
            panelStandUp.Visible = false;
            lblStand.Text = "Stand (" + txtTimeStand.Text + ")";
            StartTimers(1);
        }
        private void btnOkaySitDown_Click(object sender, EventArgs e)
        {
            panelSitDown.Visible = false;
            lblSit.Text = "Sit (" + txtTimeSit.Text + ")";
            StartTimers(2);
        }

        public void StopTimers()
        {
            timerStand.Stop();
            timerSit.Stop();
            timerSeconds.Stop();
        }
        public void StartTimers(int identifier)
        {
            if (identifier == 1)
                timerStand.Start();
            else
                timerSit.Start();
            timerSeconds.Start();
        }


        private void TimerStand_Tick(object sender, EventArgs e)
        {
            int.TryParse(lblStand.Text.Split('(')[1].Split(')')[0], out standTime);

            standTime--;
            lblStand.Text = "Stand (" + standTime + ")";

            if (standTime == 0)
            {
                panelStandUp.Visible = false;
                panelSitDown.Visible = true;
                StopTimers();
            }
        }
        private void TimerSit_Tick(object sender, EventArgs e)
        {
            int.TryParse(lblSit.Text.Split('(')[1].Split(')')[0], out sitTime);

            sitTime--;
            lblSit.Text = "Sit (" + sitTime + ")";

            if (sitTime == 0)
            {
                panelStandUp.Visible = true;
                panelSitDown.Visible = false;
                StopTimers();
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
