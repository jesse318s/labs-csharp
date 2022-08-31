using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace JesseSitesCSFinalProject
{
    public partial class frmReader : Form
    {
        public frmReader()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        double[] grades = new double[6];

        private void frmReader_Load(object sender, EventArgs e)
        {
            StreamReader streamreader = new StreamReader(@"grades.txt");
            int x = 0;

            while (!streamreader.EndOfStream)
            {
                grades[x] = double.Parse(streamreader.ReadLine());
                lbxGrades.Items.Add(grades[x]);
                x++;
            }
            streamreader.Close();
        }

        private void btnGrades_Click(object sender, EventArgs e)
        {
            lblLettersOutput.Text = "";
            int x = 0;
            double total = 0;

            while (x != grades.Length)
            {
                total = total + grades[x];
                x++;
            }
            x = 0;
            double average = total / grades.Length;
            lblTotalOutput.Text = total.ToString();
            lblAverageOutput.Text = average.ToString();
            while (x != grades.Length)
            {
                if (grades[x] >= 90)
                {
                    lblLettersOutput.Text += grades[x] + " - A\n";
                }
                else if (grades[x] >= 80)
                {
                    lblLettersOutput.Text += grades[x] + " - B\n";
                }
                else if (grades[x] >= 70)
                {
                    lblLettersOutput.Text += grades[x] + " - C\n";
                }
                else if (grades[x] >= 60)
                {
                    lblLettersOutput.Text += grades[x] + " - D\n";
                }
                else
                {
                    lblLettersOutput.Text += grades[x] + " - F\n";
                }
                x++;
            }
        }
    }
}
