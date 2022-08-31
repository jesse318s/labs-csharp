using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JesseSites1A
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            lblTranslate.Text = "rot";
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            lblTranslate.Text = "gelb";
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            lblTranslate.Text = "blau";
        }
    }
}
