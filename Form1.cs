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
        private bool showAlert = true;

        public SafeAbuse()
        {
            InitializeComponent();
        }

        private void btnStopTimer_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void btnResetTimer_Click(object sender, EventArgs e)
        {
            timer.Stop();
            lblStand.Text = "Stand (00)";
            lblSit.Text = "Sit (00)";
        }

        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            int.TryParse(lblStand.Text.Split('(')[1].Split(')')[0], out int lblStandTimer);
            int.TryParse(lblSit.Text.Split('(')[1].Split(')')[0], out int lblSitTimer);

            if (lblSitTimer == 0 || lblStandTimer != 0)
            {
                if(showAlert)
                {
                    showAlert = false;
                    MessageBox.Show("Stand-Up");
                }

                if (lblStandTimer != 0)
                {
                    lblStand.Text = "Stand (" + standTime + ")";
                }

                else if (int.TryParse(txtTimeStand.Text, out standTime))
                {
                    lblStand.Text = "Stand (" + standTime + ")";
                }
                standTime--;

                if (lblStandTimer == 1)
                    showAlert = true;
            }

            if(lblStandTimer == 0)
            {

                if (showAlert)
                {
                    showAlert = false;
                    MessageBox.Show("Sit-Down");
                }

                if(lblSitTimer != 0)
                {
                    lblSit.Text = "Sit (" + sitTime + ")";
                }
                else if (int.TryParse(txtTimeSit.Text, out sitTime))
                {
                    lblSit.Text = "Sit (" + sitTime + ")";
                }
                sitTime--;

                if (lblSitTimer == 1)
                    showAlert = true;
            }
        }
    }
}
