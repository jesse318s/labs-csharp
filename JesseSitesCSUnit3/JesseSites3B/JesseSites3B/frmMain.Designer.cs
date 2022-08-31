
namespace JesseSites3B
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
            this.lblGames = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblExpertise = new System.Windows.Forms.Label();
            this.lblPointsOutput = new System.Windows.Forms.Label();
            this.lblExpertiseOutput = new System.Windows.Forms.Label();
            this.tbxGamesInput = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGames
            // 
            this.lblGames.AutoSize = true;
            this.lblGames.Location = new System.Drawing.Point(21, 20);
            this.lblGames.Name = "lblGames";
            this.lblGames.Size = new System.Drawing.Size(227, 15);
            this.lblGames.TabIndex = 0;
            this.lblGames.Text = "Number of games completed this month:";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(166, 69);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(82, 15);
            this.lblPoints.TabIndex = 1;
            this.lblPoints.Text = "Points earned:";
            // 
            // lblExpertise
            // 
            this.lblExpertise.AutoSize = true;
            this.lblExpertise.Location = new System.Drawing.Point(147, 117);
            this.lblExpertise.Name = "lblExpertise";
            this.lblExpertise.Size = new System.Drawing.Size(101, 15);
            this.lblExpertise.TabIndex = 2;
            this.lblExpertise.Text = "Level of expertise:";
            // 
            // lblPointsOutput
            // 
            this.lblPointsOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPointsOutput.Location = new System.Drawing.Point(264, 69);
            this.lblPointsOutput.Name = "lblPointsOutput";
            this.lblPointsOutput.Size = new System.Drawing.Size(100, 23);
            this.lblPointsOutput.TabIndex = 3;
            // 
            // lblExpertiseOutput
            // 
            this.lblExpertiseOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblExpertiseOutput.Location = new System.Drawing.Point(264, 117);
            this.lblExpertiseOutput.Name = "lblExpertiseOutput";
            this.lblExpertiseOutput.Size = new System.Drawing.Size(100, 23);
            this.lblExpertiseOutput.TabIndex = 4;
            // 
            // tbxGamesInput
            // 
            this.tbxGamesInput.Location = new System.Drawing.Point(264, 17);
            this.tbxGamesInput.Name = "tbxGamesInput";
            this.tbxGamesInput.Size = new System.Drawing.Size(100, 23);
            this.tbxGamesInput.TabIndex = 5;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(331, 159);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 188);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.tbxGamesInput);
            this.Controls.Add(this.lblExpertiseOutput);
            this.Controls.Add(this.lblPointsOutput);
            this.Controls.Add(this.lblExpertise);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblGames);
            this.Name = "frmMain";
            this.Text = "Game Club";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGames;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblExpertise;
        private System.Windows.Forms.Label lblPointsOutput;
        private System.Windows.Forms.Label lblExpertiseOutput;
        private System.Windows.Forms.TextBox tbxGamesInput;
        private System.Windows.Forms.Button btnCheck;
    }
}

