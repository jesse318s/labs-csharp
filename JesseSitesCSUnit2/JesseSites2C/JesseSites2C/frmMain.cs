using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JesseSites2C
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void pbx90_Click(object sender, EventArgs e)
        {
            lblCaloriesOutput.Text = (int.Parse(lblCaloriesOutput.Text) + 90).ToString();
            lblCaloriesOutput.BackColor = Color.Orange;
        }

        private void pbx120_Click(object sender, EventArgs e)
        {
            lblCaloriesOutput.Text = (int.Parse(lblCaloriesOutput.Text) + 120).ToString();
            lblCaloriesOutput.BackColor = Color.Green;
        }

        private void pbx115_Click(object sender, EventArgs e)
        {
            lblCaloriesOutput.Text = (int.Parse(lblCaloriesOutput.Text) + 115).ToString();
            lblCaloriesOutput.BackColor = Color.Yellow;
        }

        private void pbx80_Click(object sender, EventArgs e)
        {
            lblCaloriesOutput.Text = (int.Parse(lblCaloriesOutput.Text) + 80).ToString();
            lblCaloriesOutput.BackColor = Color.Red;
        }

        private void btnCaloriesLeft_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have " + (1200 - int.Parse(lblCaloriesOutput.Text)) + " calories remaining today.");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblCaloriesOutput.Text = "0";
            MessageBox.Show("You have 1200 calories remaining today.");
            lblCaloriesOutput.BackColor = Color.Orange;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
