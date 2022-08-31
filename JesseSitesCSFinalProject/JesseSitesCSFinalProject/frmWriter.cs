using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace JesseSitesCSFinalProject
{
    public partial class frmWriter : Form
    {
        public frmWriter()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int x = 100;
            using StreamWriter file = new StreamWriter(@"even.txt");

            lbxEven.Items.Clear();
            while (x < 202)
            {
                file.WriteLine(x);
                lbxEven.Items.Add(x);
                x = x + 2;
            }
            file.Close();
        }
    }
}
