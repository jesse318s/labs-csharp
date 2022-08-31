using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JesseSites7B
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Purple;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void movie1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovie1 movie1 = new frmMovie1();
            movie1.ShowDialog();
        }

        private void movie2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovie2 movie2 = new frmMovie2();
            movie2.ShowDialog();
        }

        private void movie3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovie3 movie3 = new frmMovie3();
            movie3.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.Show();
        }

        private void frmMain_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show((new Point(e.X, e.Y)).ToString());
        }
    }
}
