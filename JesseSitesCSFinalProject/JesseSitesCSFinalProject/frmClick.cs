using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JesseSitesCSFinalProject
{
    public partial class frmClick : Form
    {
        public frmClick()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmClick_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show((new Point(e.X, e.Y)).ToString());
            if ((new Point(e.X, e.Y)).ToString() == "{X=250,Y=250}")
            {
                MessageBox.Show("Awesome Job!");
            }
        }
    }
}
