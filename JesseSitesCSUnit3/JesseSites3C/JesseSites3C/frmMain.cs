using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JesseSites3C
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
            int NumberOfNights = 0;
            int InitialCost = 0;
            int LocationFee = 0;
            int TotalCost;
            int TotalLodging;
            switch(lbxCruiseInput.SelectedIndex)
            {
                case 0:
                    NumberOfNights = 3;
                    InitialCost = 1000;
                    break;
                case 1:
                    NumberOfNights = 7;
                    InitialCost = 2000;
                    break;
                case 2:
                    NumberOfNights = 4;
                    InitialCost = 1500;
                    break;
                case 3:
                    NumberOfNights = 5;
                    InitialCost = 2500;
                    break;
                case 4:
                    NumberOfNights = 8;
                    InitialCost = 5000;
                    break;
            }
            switch (lbxLocationInput.SelectedIndex)
            {
                case 0:
                    LocationFee = 250;
                    break;
                case 1:
                    LocationFee = 325;
                    break;
                case 2:
                    LocationFee = 175;
                    break;
                case 3:
                    LocationFee = 300;
                    break;
                case 4:
                    LocationFee = 575;
                    break;
                case 5:
                    LocationFee = 150;
                    break;
            }
            TotalCost = NumberOfNights * LocationFee + InitialCost;
            TotalLodging = NumberOfNights * LocationFee;
            lblCruiseOutput.Text = "Intial cost is: $" + InitialCost + "\nLodging fee per night is: $" + LocationFee + "\nTotal lodging cost is: $" + TotalLodging + "\nTotal cost is: $" + TotalCost;
        }
    }
}
