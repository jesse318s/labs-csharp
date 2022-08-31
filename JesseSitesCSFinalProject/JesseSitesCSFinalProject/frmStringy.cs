using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JesseSitesCSFinalProject
{
    public partial class frmStringy : Form
    {
        public frmStringy()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxWordInput.Text = "";
            lblNewWordOutput.Text = "";
            tbxWordInput.Focus();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (tbxWordInput.Text != "")
            {
                const string vowels = "AEIOUaeio";
                string firstLetter = tbxWordInput.Text.Substring(0, 1);
                string restOfWord = tbxWordInput.Text.Substring(1, tbxWordInput.Text.Length - 1);
                int currentLetter = vowels.IndexOf(firstLetter);

                if (currentLetter == -1)
                {
                    lblNewWordOutput.Text = (restOfWord + firstLetter + "ay");
                }
                else
                {
                    lblNewWordOutput.Text = tbxWordInput.Text + "yay";
                }
            }
        }
    }
}
