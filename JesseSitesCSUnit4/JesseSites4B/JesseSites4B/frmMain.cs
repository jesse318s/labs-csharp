using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace JesseSites4B
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            double StartingAmount = double.Parse(tbxStartingAmountInput.Text);
            double Savings = StartingAmount;
            double MonthlyIncrease = double.Parse(tbxMonthlyIncreaseInput.Text.Replace("%", ""))/100;
            int MonthsNumber = int.Parse(tbxMonthsNumberInput.Text);
            int x = 0;

            lbxSavings.Items.Add("Month           Approximate Savings");

            while (x < MonthsNumber)
            {
                lbxSavings.Items.Add((x+1) + "\t\t" + Savings.ToString("C", CultureInfo.CurrentCulture) + "      ");
                Savings = Savings + Savings*MonthlyIncrease;
                x++;
            }
        }
    }
}
