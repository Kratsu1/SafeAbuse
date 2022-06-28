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
                lblStand.Text = "Stand (" + txtTimeStand.Text + ")";
                StopTimers();
                popUpSwitchPos2.Show();
            }
        }
        private void TimerSit_Tick(object sender, EventArgs e)
        {
            panelBody.Show();
            panelBody.BringToFront();

            popUpSwitchPos2.Hide();

            int.TryParse(lblSit.Text.Split('(')[1].Split(')')[0], out sitTime);

            sitTime--;

            if (sitTime == 0)
            {
                lblSit.Text = "Sit (" + txtTimeSit.Text + ")";
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

        private void popUpSwitchPos2_Load(object sender, EventArgs e)
        {

        }
    }
}
