using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JesseSites3A
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            try
            { 
                if (int.Parse(tbxIntegerInput.Text) < 1 || int.Parse(tbxIntegerInput.Text) > 10)
            {
                throw new Exception();
            }
                if (int.Parse(tbxIntegerInput.Text) == 1)
                {
                    lblEnglishOutput.Text = "One";
                    lblSpanishOutput.Text = "uno";
                }
                else
                {
                    if (int.Parse(tbxIntegerInput.Text) == 2)
                    {
                        lblEnglishOutput.Text = "Two";
                        lblSpanishOutput.Text = "dos";
                    }
                    else
                    {
                        if (int.Parse(tbxIntegerInput.Text) == 3)
                        {
                            lblEnglishOutput.Text = "Three";
                            lblSpanishOutput.Text = "tres";
                        }
                        else
                        {
                            if (int.Parse(tbxIntegerInput.Text) == 4)
                            {
                                lblEnglishOutput.Text = "Four";
                                lblSpanishOutput.Text = "cuatro";
                            }
                            else
                            {
                                if (int.Parse(tbxIntegerInput.Text) == 5)
                                {
                                    lblEnglishOutput.Text = "Five";
                                    lblSpanishOutput.Text = "cinco";
                                }
                                else
                                {
                                    if (int.Parse(tbxIntegerInput.Text) == 6)
                                    {
                                        lblEnglishOutput.Text = "Six";
                                        lblSpanishOutput.Text = "seis";
                                    }
                                    else
                                    {
                                        if (int.Parse(tbxIntegerInput.Text) == 7)
                                        {
                                            lblEnglishOutput.Text = "Seven";
                                            lblSpanishOutput.Text = "siete";
                                        }
                                        else
                                        {
                                            if (int.Parse(tbxIntegerInput.Text) == 8)
                                            {
                                                lblEnglishOutput.Text = "Eight";
                                                lblSpanishOutput.Text = "ocho";
                                            }
                                            else
                                            {
                                                if (int.Parse(tbxIntegerInput.Text) == 9)
                                                {
                                                    lblEnglishOutput.Text = "Nine";
                                                    lblSpanishOutput.Text = "nueve";
                                                }
                                                else
                                                {
                                                    if (int.Parse(tbxIntegerInput.Text) == 10)
                                                    {
                                                        lblEnglishOutput.Text = "Ten";
                                                        lblSpanishOutput.Text = "diez";
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
