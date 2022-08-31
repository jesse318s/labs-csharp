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

namespace JesseSites5B
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
            ClearPizzas();
            ClearWings();
            ClearAppetizers();
            ClearMisc();
            ClearSummary();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (tbxTipInput.Text.Replace("$", "") == "")
            {
                tbxTipInput.Text = "0";
            }

            decimal PizzaTotal = PizzaCharges();
            decimal WingsTotal = WingCharges();
            decimal AppetizerTotal = AppetizerCharges();
            decimal MiscellaneousTotal = MiscellaneousCharges(PizzaTotal, WingsTotal, AppetizerTotal);
            decimal TaxTotal = TaxCharges(PizzaTotal, WingsTotal, AppetizerTotal);
            decimal Total = TotalCharges(PizzaTotal, WingsTotal, AppetizerTotal, TaxTotal) + decimal.Parse(tbxTipInput.Text.Replace("$", ""));

            lblFoodChargesOutput.Text = (PizzaTotal + WingsTotal + AppetizerTotal).ToString("C", CultureInfo.CurrentCulture);
            lblTaxOutput.Text = TaxTotal.ToString("C", CultureInfo.CurrentCulture);
            lblMiscOutput.Text = MiscellaneousTotal.ToString("C", CultureInfo.CurrentCulture);
            lblTipOutput.Text = string.Format(CultureInfo.CurrentCulture, "{0:C}", decimal.Parse(tbxTipInput.Text.Replace("$", "")));
            lblTotalOutput.Text = Total.ToString("C", CultureInfo.CurrentCulture);
        }

        private decimal PizzaCharges()
        {
            decimal PizzaCharge = 0;

            if (cbxSmallPizza.Checked == true)
            {
                PizzaCharge += 8;
            }

            if (cbxMediumPizza.Checked == true)
            {
                PizzaCharge += 12.25m;
            }

            if (cbxLargePizza.Checked == true)
            {
                PizzaCharge += 16;
            }

            return PizzaCharge;
        }

        private decimal WingCharges()
        {
            decimal WingsCharge = 0;

            if (cbxWings6.Checked == true)
            {
                WingsCharge += 8;
            }

            if (cbxWings12.Checked == true)
            {
                WingsCharge += 15.75m;
            }

            return WingsCharge;
        }
        private decimal AppetizerCharges()
        {
            decimal AppetizerCharge = 0;

            if (cbxMushrooms.Checked == true)
            {
                AppetizerCharge += 7.50m;
            }

            if (cbxBread.Checked == true)
            {
                AppetizerCharge += 12;
            }

            if (cbxNachos.Checked == true)
            {
                AppetizerCharge += 13;
            }

            return AppetizerCharge;
        }
        private decimal MiscellaneousCharges(decimal PizzaTotal, decimal WingsTotal, decimal AppetizerTotal)
        {
            decimal MiscellaneousCharge = 0;
            decimal Total = PizzaTotal + WingsTotal + AppetizerTotal;

            if (cbxDelivery.Checked == true)
            {
                MiscellaneousCharge += Total * 0.10m;
            }

            if (cbxTakeOut.Checked == true)
            {
                MiscellaneousCharge += Total * 0.03m;
            }

            return MiscellaneousCharge;
        }
        private decimal TaxCharges(decimal PizzaTotal, decimal WingsTotal, decimal AppetizerTotal)
        {
            decimal Total = PizzaTotal + WingsTotal + AppetizerTotal;
            decimal TaxCharge = Total * 0.06m;

            return TaxCharge;
        }
        private decimal TotalCharges(decimal PizzaTotal, decimal WingsTotal, decimal AppetizerTotal, decimal TaxTotal)
        {
            decimal Total = PizzaTotal + WingsTotal + AppetizerTotal + TaxTotal;

            return Total;
        }
        private void ClearPizzas()
        {
            cbxSmallPizza.Checked = false;

            cbxMediumPizza.Checked = false;

            cbxLargePizza.Checked = false;
        }
        private void ClearWings()
        {
            cbxWings6.Checked = false;

            cbxWings12.Checked = false;
        }
        private void ClearAppetizers()
        {
            cbxMushrooms.Checked = false;

            cbxBread.Checked = false;

            cbxNachos.Checked = false;
        }
        private void ClearMisc()
        {
            cbxDelivery.Checked = false;

            cbxTakeOut.Checked = false;

            tbxTipInput.Text = "";
        }
        private void ClearSummary()
        {
            lblFoodChargesOutput.Text = "";
            lblTaxOutput.Text = "";
            lblMiscOutput.Text = "";
            lblTipOutput.Text = "";
            lblTipOutput.Text = "";
            lblTotalOutput.Text = "";
        }
    }
}
