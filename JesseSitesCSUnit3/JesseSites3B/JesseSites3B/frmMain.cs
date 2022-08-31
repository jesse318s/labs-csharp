using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JesseSites3B
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            switch (int.Parse(tbxGamesInput.Text))
            {
                case 0:
                    lblPointsOutput.Text = "0";
                    lblExpertiseOutput.Text = "novice";
                    break;
                case 1:
                    lblPointsOutput.Text = "6";
                    lblExpertiseOutput.Text = "beginner";
                    break;
                case 2:
                    lblPointsOutput.Text = "12";
                    lblExpertiseOutput.Text = "intermediate";
                    break;
                case 3:
                    lblPointsOutput.Text = "18";
                    lblExpertiseOutput.Text = "advanced";
                    break;
                case 4:
                    lblPointsOutput.Text = "24";
                    lblExpertiseOutput.Text = "expert";
                    break;
                default:
                    lblPointsOutput.Text = "24";
                    lblExpertiseOutput.Text = "expert";
                    break;
            }
        }
    }
}
