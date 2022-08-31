using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JesseSites4C
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

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (tbxNameInput.Text == "")
            {
                MessageBox.Show("A name must be entered.");
            }
            else
            {
                string name = tbxNameInput.Text;
                using (StreamWriter writer = new StreamWriter("name.txt", true))
                {
                    writer.WriteLine(name);
                }
            }
        }
    }
}
