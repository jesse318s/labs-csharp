using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JesseSites1B
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnBaseball_Click(object sender, EventArgs e)
        {
            lblAthlete.Text = "Babe Ruth";
        }

        private void btnFootball_Click(object sender, EventArgs e)
        {
            lblAthlete.Text = "Peyton Manning";
        }

        private void btnGolf_Click(object sender, EventArgs e)
        {
            lblAthlete.Text = "Tiger Woods";
        }
    }
}
