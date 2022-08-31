
namespace JesseSites6B
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSelectTeam = new System.Windows.Forms.Label();
            this.lbxTeams = new System.Windows.Forms.ListBox();
            this.lblTeamOutput = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelectTeam
            // 
            this.lblSelectTeam.AutoSize = true;
            this.lblSelectTeam.Location = new System.Drawing.Point(12, 17);
            this.lblSelectTeam.Name = "lblSelectTeam";
            this.lblSelectTeam.Size = new System.Drawing.Size(186, 15);
            this.lblSelectTeam.TabIndex = 0;
            this.lblSelectTeam.Text = "Select one of the following teams:";
            // 
            // lbxTeams
            // 
            this.lbxTeams.FormattingEnabled = true;
            this.lbxTeams.ItemHeight = 15;
            this.lbxTeams.Location = new System.Drawing.Point(12, 35);
            this.lbxTeams.Name = "lbxTeams";
            this.lbxTeams.Size = new System.Drawing.Size(331, 154);
            this.lbxTeams.TabIndex = 1;
            this.lbxTeams.SelectedIndexChanged += new System.EventHandler(this.lbxTeams_SelectedIndexChanged);
            // 
            // lblTeamOutput
            // 
            this.lblTeamOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTeamOutput.Location = new System.Drawing.Point(12, 192);
            this.lblTeamOutput.Name = "lblTeamOutput";
            this.lblTeamOutput.Size = new System.Drawing.Size(331, 132);
            this.lblTeamOutput.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(268, 351);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 386);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTeamOutput);
            this.Controls.Add(this.lbxTeams);
            this.Controls.Add(this.lblSelectTeam);
            this.Name = "frmMain";
            this.Text = "SuperBowl Stats";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectTeam;
        private System.Windows.Forms.ListBox lbxTeams;
        private System.Windows.Forms.Label lblTeamOutput;
        private System.Windows.Forms.Button btnExit;
    }
}

