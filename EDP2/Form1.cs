using System;
using System.Deployment.Application;
using System.Windows.Forms;

namespace EDP2
{
    public partial class frmMenu : Form
    {
        frmHelp _help;
        frmAbout _about;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Make sure you have read the Help guide before playing the game", "Alert", MessageBoxButtons.OK);
            new FrmGame().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttHelp_Click(object sender, EventArgs e)
        {
            if (_help == null)
            {
                _help = new frmHelp();
            }
            _help.Show();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void buttAbout_Click(object sender, EventArgs e)
        {
            if (_about == null)
            {
                _about = new frmAbout();
            }
            _about.Show();
        }
    }
}
