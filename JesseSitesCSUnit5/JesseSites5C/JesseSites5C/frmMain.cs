using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JesseSites5C
{
    public partial class frmMain : Form
    {
        int CompChoice;
        int PlayerChoice;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            CompChoice = GenRandom();
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            PlayerChoice = 0;
            DisplayCompChoice();
            DecideWinner();
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            PlayerChoice = 1;
            DisplayCompChoice();
            DecideWinner();
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            PlayerChoice = 2;
            DisplayCompChoice();
            DecideWinner();
        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            pbxCompChoice.BackgroundImage = null;
            GenRandom();
        }

        private int GenRandom()
        {

            Random rand = new Random();
            CompChoice = rand.Next(3);

            return CompChoice;
        }

        private void DisplayCompChoice()
        {
            switch (CompChoice)
            {
                case 0:
                    pbxCompChoice.BackgroundImage = Image.FromFile(@"rock.bmp");
                    break;
                case 1:
                    pbxCompChoice.BackgroundImage = Image.FromFile(@"paper.bmp");
                    break;
                case 2:
                    pbxCompChoice.BackgroundImage = Image.FromFile(@"scissors.bmp");
                    break;
            }
        }

        private void DecideWinner()
        {
            if (PlayerChoice != CompChoice)
            {
                switch (PlayerChoice)
                {
                    case 0:
                        if (CompChoice == 1)
                        {
                            MessageBox.Show("You chose rock. You lose.");
                        }
                        else
                        {
                            MessageBox.Show("You chose rock. You win.");
                        }
                        break;
                    case 1:
                        if (CompChoice == 2)
                        {
                            MessageBox.Show("You chose paper. You lose.");
                        }
                        else
                        {
                            MessageBox.Show("You chose paper. You win.");
                        }
                        break;
                    case 2:
                        if (CompChoice == 0)
                        {
                            MessageBox.Show("You chose scissors. You lose.");
                        }
                        else
                        {
                            MessageBox.Show("You chose scissors. You win.");
                        }
                        break;
                }
            }
            else
            {
                switch (PlayerChoice)
                {
                    case 0:
                        MessageBox.Show("You chose rock. Tie. Play again.");
                        break;
                    case 1:
                        MessageBox.Show("You chose paper. Tie. Play again.");
                        break;
                    case 2:
                        MessageBox.Show("You chose scissors. Tie. Play again.");
                        break;
                }
                pbxCompChoice.BackgroundImage = null;
                GenRandom();
            }

        }
    }
}
