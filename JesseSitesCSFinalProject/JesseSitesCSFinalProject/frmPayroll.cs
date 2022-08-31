using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JesseSitesCSFinalProject
{
    public partial class frmPayroll : Form
    {
        public frmPayroll()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxHoursWorkedInput.Text = "";
            tbxRateOfPayInput.Text = "";
            lbxEmployeeInfo.Items.Clear();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
           decimal grossPay = GrossPay(decimal.Parse(tbxHoursWorkedInput.Text), decimal.Parse(tbxRateOfPayInput.Text));
           decimal deductions = Deductions(grossPay);
           NetPay(grossPay, deductions);
        }
        private decimal GrossPay(decimal hoursWorked, decimal rateOfPay)
        {
            decimal grossPay = hoursWorked * rateOfPay;
            if (hoursWorked > 40)
            {
                grossPay = grossPay + ((hoursWorked - 40) * (rateOfPay * 1.5m));
            }
            return grossPay;
        }
        private decimal Deductions(decimal grossPay)
        {
            decimal fica = .065m*grossPay;
            decimal tax = 0m;
            if (grossPay <= 200m)
            {

            }
            else if (grossPay < 500m)
            {
                tax = tax + (0.05m * grossPay);
            }
            else if (grossPay >= 500m)
            {
                tax = tax + (0.075m * grossPay);
            }
            decimal deductions = fica + tax;
            return deductions;
        }
        private void NetPay(decimal grossPay, decimal deductions)
        {
            decimal netPay = grossPay - deductions;

            lbxEmployeeInfo.Items.Add("Hours worked:");
            lbxEmployeeInfo.Items.Add(tbxHoursWorkedInput.Text);
            lbxEmployeeInfo.Items.Add("Rate of pay:");
            lbxEmployeeInfo.Items.Add("$" + tbxRateOfPayInput.Text);
            lbxEmployeeInfo.Items.Add("Gross pay:");
            lbxEmployeeInfo.Items.Add("$" + grossPay);
            lbxEmployeeInfo.Items.Add("Deductions:");
            lbxEmployeeInfo.Items.Add("$" + deductions);
            lbxEmployeeInfo.Items.Add("Net pay:");
            lbxEmployeeInfo.Items.Add("$" + (grossPay - deductions));
        }

    }
}
