using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JesseSites2B
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
            lblSentence.Text = "";
            BackColor = Color.Orange;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            lblSentence.Text = lblSentence.Text + btnA.Text;
            btnA.BackColor = Color.Yellow;
        }

        private void btnALower_Click(object sender, EventArgs e)
        {
            lblSentence.Text = lblSentence.Text + btnALower.Text;
            btnALower.BackColor = Color.Yellow;
        }

        private void btnAn_Click(object sender, EventArgs e)
        {
            lblSentence.Text = lblSentence.Text + btnAn.Text;
            btnAn.BackColor = Color.Yellow;
        }

        private void btnAnLower_Click(object sender, EventArgs e)
        {
            lblSentence.Text = lblSentence.Text + btnAnLower.Text;
            btnAnLower.BackColor = Color.Yellow;
        }

        private void btnThe_Click(object sender, EventArgs e)
        {
            lblSentence.Text = lblSentence.Text + btnThe.Text;
            btnThe.BackColor = Color.Yellow;
        }

        private void btnTheLower_Click(object sender, EventArgs e)
        {
            lblSentence.Text = lblSentence.Text + btnTheLower.Text;
            btnTheLower.BackColor = Color.Yellow;
        }

        private void btnMan_Click(object sender, EventArgs e)
        {
            lblSentence.Text = lblSentence.Text + btnMan.Text;
            btnMan.BackColor = Color.Yellow;
        }

        private void btnWoman_Click(object sender, EventArgs e)
        {
            lblSentence.Text = lblSentence.Text + btnWoman.Text;
            btnWoman.BackColor = Color.Yellow;
        }

        private void btnDog_Click(object sender, EventArgs e)
        {
            lblSentence.Text = lblSentence.Text + btnDog.Text;
            btnDog.BackColor = Color.Yellow;
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            lblSentence.Text = lblSentence.Text + btnCat.Text;
            btnCat.BackColor = Color.Yellow;
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            lblSentence.Text = lblSentence.Text + btnCar.Text;
            btnCar.BackColor = Color.Yellow;
        }

        private void btnBicycle_Click(object sender, EventArgs e)
        {
            lblSentence.Text = lblSentence.Text + btnBicycle.Text;
            btnBicycle.BackColor = Color.Yellow;
        }

        private void btnBeautiful_Click(object sender, EventArgs e)
        {
            lblSentence.Text = lblSentence.Text + btnBeautiful.Text;
            btnBeautiful.BackColor = Color.Yellow;
        }

        private void btnBig_Click(object sender, EventArgs e)
        {
            lblSentence.Text = lblSentence.Text + btnBig.Text;
            btnBig.BackColor = Color.Yellow;
        }

        private void btnSmall_Click(object sender, EventArgs e)
        {
            lblSentence.Text = lblSentence.Text + btnSmall.Text;
            btnSmall.BackColor = Color.Yellow;
        }

        private void btnStrange_Click(object sender, EventArgs e)
        {
            lblSentence.Text = lblSentence.Text + btnStrange.Text;
            btnStrange.BackColor = Color.Yellow;
        }

        private void btnLookedAt_Click(object sender, EventArgs e)
        {
            lblSentence.Text = lblSentence.Text + btnLookedAt.Text;
            btnLookedAt.BackColor = Color.Yellow;
        }

        private void btnRode_Click(object sender, EventArgs e)
        {
            lblSentence.Text = lblSentence.Text + btnRode.Text;
            btnRode.BackColor = Color.Yellow;
        }

        private void btnSpokeTo_Click(object sender, EventArgs e)
        {
            lblSentence.Text = lblSentence.Text + btnSpokeTo.Text;
            btnSpokeTo.BackColor = Color.Yellow;
        }

        private void btnLaughedAt_Click(object sender, EventArgs e)
        {
            lblSentence.Text = lblSentence.Text + btnLaughedAt.Text;
            btnLaughedAt.BackColor = Color.Yellow;
        }

        private void btnDrove_Click(object sender, EventArgs e)
        {
            lblSentence.Text = lblSentence.Text + btnDrove.Text;
            btnDrove.BackColor = Color.Yellow;
        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            lblSentence.Text = lblSentence.Text + " ";
            btnSpace.BackColor = Color.Yellow;
        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            lblSentence.Text = lblSentence.Text + btnPeriod.Text;
            btnPeriod.BackColor = Color.Yellow;
        }

        private void btnExclamation_Click(object sender, EventArgs e)
        {
            lblSentence.Text = lblSentence.Text + btnExclamation.Text;
            btnExclamation.BackColor = Color.Yellow;
        }
    }
}
