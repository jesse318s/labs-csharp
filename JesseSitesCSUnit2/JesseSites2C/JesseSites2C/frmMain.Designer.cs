
namespace JesseSites2C
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pbx90 = new System.Windows.Forms.PictureBox();
            this.pbx120 = new System.Windows.Forms.PictureBox();
            this.pbx115 = new System.Windows.Forms.PictureBox();
            this.pbx80 = new System.Windows.Forms.PictureBox();
            this.btnCaloriesLeft = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCaloriesOutput = new System.Windows.Forms.Label();
            this.lblTotalCalories = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx90)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx120)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx115)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx80)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx90
            // 
            this.pbx90.Image = ((System.Drawing.Image)(resources.GetObject("pbx90.Image")));
            this.pbx90.Location = new System.Drawing.Point(40, 28);
            this.pbx90.Name = "pbx90";
            this.pbx90.Size = new System.Drawing.Size(134, 174);
            this.pbx90.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx90.TabIndex = 0;
            this.pbx90.TabStop = false;
            this.pbx90.Click += new System.EventHandler(this.pbx90_Click);
            // 
            // pbx120
            // 
            this.pbx120.Image = ((System.Drawing.Image)(resources.GetObject("pbx120.Image")));
            this.pbx120.Location = new System.Drawing.Point(236, 28);
            this.pbx120.Name = "pbx120";
            this.pbx120.Size = new System.Drawing.Size(150, 174);
            this.pbx120.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx120.TabIndex = 1;
            this.pbx120.TabStop = false;
            this.pbx120.Click += new System.EventHandler(this.pbx120_Click);
            // 
            // pbx115
            // 
            this.pbx115.Image = ((System.Drawing.Image)(resources.GetObject("pbx115.Image")));
            this.pbx115.Location = new System.Drawing.Point(40, 258);
            this.pbx115.Name = "pbx115";
            this.pbx115.Size = new System.Drawing.Size(134, 177);
            this.pbx115.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx115.TabIndex = 2;
            this.pbx115.TabStop = false;
            this.pbx115.Click += new System.EventHandler(this.pbx115_Click);
            // 
            // pbx80
            // 
            this.pbx80.Image = ((System.Drawing.Image)(resources.GetObject("pbx80.Image")));
            this.pbx80.Location = new System.Drawing.Point(236, 258);
            this.pbx80.Name = "pbx80";
            this.pbx80.Size = new System.Drawing.Size(150, 177);
            this.pbx80.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx80.TabIndex = 3;
            this.pbx80.TabStop = false;
            this.pbx80.Click += new System.EventHandler(this.pbx80_Click);
            // 
            // btnCaloriesLeft
            // 
            this.btnCaloriesLeft.Location = new System.Drawing.Point(469, 219);
            this.btnCaloriesLeft.Name = "btnCaloriesLeft";
            this.btnCaloriesLeft.Size = new System.Drawing.Size(75, 45);
            this.btnCaloriesLeft.TabIndex = 4;
            this.btnCaloriesLeft.Text = "&Calories Left";
            this.btnCaloriesLeft.UseVisualStyleBackColor = true;
            this.btnCaloriesLeft.Click += new System.EventHandler(this.btnCaloriesLeft_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(469, 295);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 47);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(469, 373);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 46);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCaloriesOutput
            // 
            this.lblCaloriesOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCaloriesOutput.Location = new System.Drawing.Point(432, 90);
            this.lblCaloriesOutput.Name = "lblCaloriesOutput";
            this.lblCaloriesOutput.Size = new System.Drawing.Size(165, 41);
            this.lblCaloriesOutput.TabIndex = 7;
            this.lblCaloriesOutput.Text = "0";
            this.lblCaloriesOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCalories
            // 
            this.lblTotalCalories.AutoSize = true;
            this.lblTotalCalories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalCalories.Location = new System.Drawing.Point(459, 57);
            this.lblTotalCalories.Name = "lblTotalCalories";
            this.lblTotalCalories.Size = new System.Drawing.Size(102, 21);
            this.lblTotalCalories.TabIndex = 8;
            this.lblTotalCalories.Text = "Total Calories";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 471);
            this.Controls.Add(this.lblTotalCalories);
            this.Controls.Add(this.lblCaloriesOutput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCaloriesLeft);
            this.Controls.Add(this.pbx80);
            this.Controls.Add(this.pbx115);
            this.Controls.Add(this.pbx120);
            this.Controls.Add(this.pbx90);
            this.Name = "frmMain";
            this.Text = "Calorie Counter";
            ((System.ComponentModel.ISupportInitialize)(this.pbx90)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx120)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx115)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx80)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx90;
        private System.Windows.Forms.PictureBox pbx120;
        private System.Windows.Forms.PictureBox pbx115;
        private System.Windows.Forms.PictureBox pbx80;
        private System.Windows.Forms.Button btnCaloriesLeft;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCaloriesOutput;
        private System.Windows.Forms.Label lblTotalCalories;
    }
}

