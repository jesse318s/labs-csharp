using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JesseSitesCSFinalProject
{
    public partial class frmColor : Form
    {
        public frmColor()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnColorMe_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int random = rnd.Next(0, 6);

            if (random == 0)
            {
                BackColor = Color.Yellow;
            }
            else if (random == 1)
            {
                BackColor = Color.Red;
            }
            else if (random == 2)
            {
                BackColor = Color.Blue;
            }
            else if (random == 3)
            {
                BackColor = Color.Green;
            }
            else if (random == 4)
            {
                BackColor = Color.Purple;
            }
            else if (random == 5)
            {
                BackColor = Color.Orange;
            }
        }
    }
}
