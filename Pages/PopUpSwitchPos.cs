using System;
using System.Windows.Forms;

namespace SafeAbuse.Pages
{
    public partial class PopUpSwitchPos : UserControl
    {
        public PopUpSwitchPos()
        {
            InitializeComponent();
        }

        private void btnSwitchOkay_Click(object sender, EventArgs e)
        {
            SafeAbuse homeObject = new SafeAbuse();
            homeObject.StartTimers(2);
        }
    }
}
