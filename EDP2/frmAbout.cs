using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDP2
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
            webHelp.Navigate("http://untamemadman.github.io/EDP2/About/");
        }

        private void buttClose_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
