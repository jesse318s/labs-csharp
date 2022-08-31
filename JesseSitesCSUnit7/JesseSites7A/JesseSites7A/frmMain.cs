using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JesseSites7A
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        Car myCar = new Car(1980, "Ford");

        private void btnAccelerate_Click(object sender, EventArgs e)
        {
            myCar.Accelerate();
            lblSpeed.Text = Convert.ToString(myCar.Speed);
        }

        private void btnBrake_Click(object sender, EventArgs e)
        {
            myCar.Brake();
            lblSpeed.Text = Convert.ToString(myCar.Speed);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
