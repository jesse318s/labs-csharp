using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JesseSites4A
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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int TuitionPerHour = int.Parse(tbxTuitionPerHourInput.Text);
            int HoursSemester = int.Parse(tbxHoursSemesterInput.Text);

            for (int i = 1; i < HoursSemester+1; i++)
            {
                lbxCost.Items.Add("After hour " + i + " the cost is $" + (i * TuitionPerHour));
            }
        }
    }
}
