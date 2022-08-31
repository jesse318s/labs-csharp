using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JesseSites6A
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        string[] salesList;
        private void frmMain_Load(object sender, EventArgs e)
        {
            StreamReader fileIn;

            fileIn = File.OpenText("Sales.txt");
            salesList = File.ReadAllLines("Sales.txt");
            foreach (string str in salesList)
            {
                lbxValues.Items.Add(str);
            }


            fileIn.Close();

        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            int length = 0;

            foreach (string str in salesList)
            {
                total = total + decimal.Parse(str);
                length++;
            }

            decimal average = total / length;
            decimal largest = findLargest();
            decimal smallest = findSmallest();


            lblTotalOutput.Text = Convert.ToString(total);
            lblAverageOutput.Text = Convert.ToString(average);
            lblLargestOutput.Text = Convert.ToString(largest);
            lblSmallestOutput.Text = Convert.ToString(smallest);
        }


        private decimal findLargest()
        {
            decimal largest = 0;

            foreach (string str in salesList)
            {
                if (decimal.Parse(str) > largest)
                {
                    largest = decimal.Parse(str);
                }
            }

            return largest;
        }

        private decimal findSmallest()
        {
            decimal smallest = 999999999;

            foreach (string str in salesList)
            {
                if (decimal.Parse(str) < smallest)
                {
                    smallest = decimal.Parse(str);
                }
            }

            return smallest;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
