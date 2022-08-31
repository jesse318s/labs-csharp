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

namespace JesseSites5A
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxCostInput.Text = "";
            tbxSalesInput.Text = "";
            lblSavingsOutput.Text = "";
            lblSalesPriceOutput.Text = "";
            tbxCostInput.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool Validation = ValidateInput();
            if (Validation == true)
            {
                decimal SalesCost = CalculateSalePrice(decimal.Parse(tbxCostInput.Text.Replace("$", "")), decimal.Parse(tbxSalesInput.Text.Replace("%", "")));
                lblSalesPriceOutput.Text = "The sales price is " + SalesCost.ToString("C", CultureInfo.CurrentCulture);
            }
            else
            {
                MessageBox.Show("Input invalid. Please try again.");
                tbxCostInput.Text = "";
                tbxSalesInput.Text = "";
                lblSavingsOutput.Text = "";
                lblSalesPriceOutput.Text = "";
                tbxCostInput.Focus();
            }
        }

        private decimal CalculateSalePrice(decimal RegularCost, decimal SalesPercentage)
        {
            decimal SalesCost = RegularCost - (RegularCost * SalesPercentage/100);
            lblSavingsOutput.Text = (RegularCost - SalesCost).ToString("C", CultureInfo.CurrentCulture);
            return SalesCost;
        }

        private bool ValidateInput()
        {
            decimal a = 0;
            decimal b = 0;

            if (decimal.TryParse(tbxSalesInput.Text.Replace("%", ""), out a) && decimal.TryParse(tbxCostInput.Text.Replace("$", ""), out b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
