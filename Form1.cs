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
        public SafeAbuse()
        {
            InitializeComponent();
        }

        private void btnStartTimer_Click(object sender, EventArgs e)
        {

            if(int.TryParse(txtTimeStand.Text, out int standTime) && int.TryParse(txtTimeSit.Text, out int sitTime))
            {
                lblStand.Text = "Stand (" + standTime+ ")";
                lblSit.Text = "Sit (" + sitTime+ ")";


                
                MessageBox.Show(standTime + " " + sitTime);

            }

            else
            {
                MessageBox.Show("Enter Number");
            }


        }
    }
}
