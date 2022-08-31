using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JesseSitesCSFinalProject
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxNum1Input.Text = "";
            tbxOperandInput.Text = "";
            tbxNum2Input.Text = "";
            lblResultOutput.Text = "";
            tbxNum1Input.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string operand = tbxOperandInput.Text;
            decimal num1 = decimal.Parse(tbxNum1Input.Text);
            decimal num2 = decimal.Parse(tbxNum2Input.Text);

            switch (operand)
            {
                case "+":
                    lblResultOutput.Text = "= " + (num1 + num2);
                    break;
                case "-":
                    lblResultOutput.Text = "= " + (num1 - num2);
                    break;
                case "*":
                    lblResultOutput.Text = "= " + (num1 * num2);
                    break;
                default:
                    break;
            }
        }
    }
}
