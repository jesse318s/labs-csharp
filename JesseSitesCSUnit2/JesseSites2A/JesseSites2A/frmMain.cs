using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JesseSites2A
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxHoursOnTrain.Text = "";
            lblOutputDistanceTraveled.Text = "";
        }

        private void btn55Mph_Click(object sender, EventArgs e)
        {
            lblOutputDistanceTraveled.Text = (55 * int.Parse(tbxHoursOnTrain.Text)).ToString();
        }

        private void btn75Mph_Click(object sender, EventArgs e)
        {
            lblOutputDistanceTraveled.Text = (75 * int.Parse(tbxHoursOnTrain.Text)).ToString();
        }

        private void btn95Mph_Click(object sender, EventArgs e)
        {
            lblOutputDistanceTraveled.Text = (95 * int.Parse(tbxHoursOnTrain.Text)).ToString();
        }
    }
}
