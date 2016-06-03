using System;
using System.Windows.Forms;

namespace EDP2
{
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
            webHelp.Navigate("http://untamemadman.github.io/EDP2/Help/");
        }

        private void buttClose_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
