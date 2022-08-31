using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JesseSitesCSFinalProject
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void colorMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColor color = new frmColor();
            color.ShowDialog();
        }

        private void writeItToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWriter writer = new frmWriter();
            writer.ShowDialog();
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculator calculator = new frmCalculator();
            calculator.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmStringy stringy = new frmStringy();
            stringy.ShowDialog();
        }

        private void readItToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReader reader = new frmReader();
            reader.ShowDialog();
        }

        private void payrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPayroll payroll = new frmPayroll();
            payroll.ShowDialog();
        }

        private void clickMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClick click = new frmClick();
            click.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }
    }
}
