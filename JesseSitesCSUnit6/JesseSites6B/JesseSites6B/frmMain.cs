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

namespace JesseSites6B
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        string[] teamsList;
        private void frmMain_Load(object sender, EventArgs e)
        {
            StreamReader fileIn;

            fileIn = File.OpenText("Teams.txt");
            teamsList = File.ReadAllLines("Teams.txt");
            foreach (string str in teamsList)
            {
                lbxTeams.Items.Add(str);
            }

            fileIn.Close();

        }
        string[] winsList;
        private void lbxTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            string team = lbxTeams.Text;
            int wins = 0;

            StreamReader fileIn;

            fileIn = File.OpenText("SuperBowlWinners.txt");
            winsList = File.ReadAllLines("SuperBowlWinners.txt");
            foreach (string str in winsList)
            {
                if (str == team)
                {
                    wins = wins + 1;
                }
            }

            lblTeamOutput.Text = team + " won " + wins + " times.";

            fileIn.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
