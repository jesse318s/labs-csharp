
namespace JesseSites1B
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
            this.btnBaseball = new System.Windows.Forms.Button();
            this.btnFootball = new System.Windows.Forms.Button();
            this.btnGolf = new System.Windows.Forms.Button();
            this.lblAthlete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBaseball
            // 
            this.btnBaseball.Location = new System.Drawing.Point(50, 313);
            this.btnBaseball.Name = "btnBaseball";
            this.btnBaseball.Size = new System.Drawing.Size(87, 39);
            this.btnBaseball.TabIndex = 0;
            this.btnBaseball.Text = "&Baseball";
            this.btnBaseball.UseVisualStyleBackColor = true;
            this.btnBaseball.Click += new System.EventHandler(this.btnBaseball_Click);
            // 
            // btnFootball
            // 
            this.btnFootball.Location = new System.Drawing.Point(343, 313);
            this.btnFootball.Name = "btnFootball";
            this.btnFootball.Size = new System.Drawing.Size(102, 39);
            this.btnFootball.TabIndex = 1;
            this.btnFootball.Text = "&Football";
            this.btnFootball.UseVisualStyleBackColor = true;
            this.btnFootball.Click += new System.EventHandler(this.btnFootball_Click);
            // 
            // btnGolf
            // 
            this.btnGolf.Location = new System.Drawing.Point(638, 313);
            this.btnGolf.Name = "btnGolf";
            this.btnGolf.Size = new System.Drawing.Size(111, 39);
            this.btnGolf.TabIndex = 2;
            this.btnGolf.Text = "&Golf";
            this.btnGolf.UseVisualStyleBackColor = true;
            this.btnGolf.Click += new System.EventHandler(this.btnGolf_Click);
            // 
            // lblAthlete
            // 
            this.lblAthlete.BackColor = System.Drawing.Color.Khaki;
            this.lblAthlete.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAthlete.Location = new System.Drawing.Point(50, 87);
            this.lblAthlete.Name = "lblAthlete";
            this.lblAthlete.Size = new System.Drawing.Size(700, 100);
            this.lblAthlete.TabIndex = 3;
            this.lblAthlete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAthlete);
            this.Controls.Add(this.btnGolf);
            this.Controls.Add(this.btnFootball);
            this.Controls.Add(this.btnBaseball);
            this.Name = "frmMain";
            this.Text = "Sports Fan";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBaseball;
        private System.Windows.Forms.Button btnFootball;
        private System.Windows.Forms.Button btnGolf;
        private System.Windows.Forms.Label lblAthlete;
    }
}

