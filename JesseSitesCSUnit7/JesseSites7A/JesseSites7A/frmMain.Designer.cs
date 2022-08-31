
namespace JesseSites7A
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
            this.lblSpeed = new System.Windows.Forms.Label();
            this.btnBrake = new System.Windows.Forms.Button();
            this.btnAccelerate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSpeed
            // 
            this.lblSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSpeed.Location = new System.Drawing.Point(12, 19);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(262, 27);
            this.lblSpeed.TabIndex = 0;
            // 
            // btnBrake
            // 
            this.btnBrake.Location = new System.Drawing.Point(156, 49);
            this.btnBrake.Name = "btnBrake";
            this.btnBrake.Size = new System.Drawing.Size(75, 23);
            this.btnBrake.TabIndex = 2;
            this.btnBrake.Text = "Brake";
            this.btnBrake.UseVisualStyleBackColor = true;
            this.btnBrake.Click += new System.EventHandler(this.btnBrake_Click);
            // 
            // btnAccelerate
            // 
            this.btnAccelerate.Location = new System.Drawing.Point(75, 49);
            this.btnAccelerate.Name = "btnAccelerate";
            this.btnAccelerate.Size = new System.Drawing.Size(75, 23);
            this.btnAccelerate.TabIndex = 1;
            this.btnAccelerate.Text = "Accelerate";
            this.btnAccelerate.UseVisualStyleBackColor = true;
            this.btnAccelerate.Click += new System.EventHandler(this.btnAccelerate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(212, 81);
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
            this.ClientSize = new System.Drawing.Size(299, 109);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAccelerate);
            this.Controls.Add(this.btnBrake);
            this.Controls.Add(this.lblSpeed);
            this.Name = "frmMain";
            this.Text = "Car Class";
//            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Button btnBrake;
        private System.Windows.Forms.Button btnAccelerate;
        private System.Windows.Forms.Button btnExit;
    }
}

