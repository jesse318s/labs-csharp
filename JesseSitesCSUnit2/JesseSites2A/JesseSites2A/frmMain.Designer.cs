
namespace JesseSites2A
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
            this.lblHoursOnTrain = new System.Windows.Forms.Label();
            this.lblDistanceTraveled = new System.Windows.Forms.Label();
            this.lblOutputDistanceTraveled = new System.Windows.Forms.Label();
            this.tbxHoursOnTrain = new System.Windows.Forms.TextBox();
            this.btn55Mph = new System.Windows.Forms.Button();
            this.btn75Mph = new System.Windows.Forms.Button();
            this.btn95Mph = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHoursOnTrain
            // 
            this.lblHoursOnTrain.AutoSize = true;
            this.lblHoursOnTrain.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHoursOnTrain.Location = new System.Drawing.Point(166, 45);
            this.lblHoursOnTrain.Name = "lblHoursOnTrain";
            this.lblHoursOnTrain.Size = new System.Drawing.Size(236, 30);
            this.lblHoursOnTrain.TabIndex = 0;
            this.lblHoursOnTrain.Text = "Time on Train in Hours:";
            // 
            // lblDistanceTraveled
            // 
            this.lblDistanceTraveled.AutoSize = true;
            this.lblDistanceTraveled.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDistanceTraveled.Location = new System.Drawing.Point(215, 140);
            this.lblDistanceTraveled.Name = "lblDistanceTraveled";
            this.lblDistanceTraveled.Size = new System.Drawing.Size(187, 30);
            this.lblDistanceTraveled.TabIndex = 1;
            this.lblDistanceTraveled.Text = "Distance Traveled:";
            // 
            // lblOutputDistanceTraveled
            // 
            this.lblOutputDistanceTraveled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutputDistanceTraveled.Location = new System.Drawing.Point(441, 132);
            this.lblOutputDistanceTraveled.Name = "lblOutputDistanceTraveled";
            this.lblOutputDistanceTraveled.Size = new System.Drawing.Size(143, 49);
            this.lblOutputDistanceTraveled.TabIndex = 2;
//            this.lblOutputDistanceTraveled.Click += new System.EventHandler(this.lblOutputDistanceTraveled_Click);
            // 
            // tbxHoursOnTrain
            // 
            this.tbxHoursOnTrain.Location = new System.Drawing.Point(441, 52);
            this.tbxHoursOnTrain.Multiline = true;
            this.tbxHoursOnTrain.Name = "tbxHoursOnTrain";
            this.tbxHoursOnTrain.Size = new System.Drawing.Size(143, 35);
            this.tbxHoursOnTrain.TabIndex = 3;
//            this.tbxHoursOnTrain.TextChanged += new System.EventHandler(this.tbxHoursOnTrain_TextChanged);
            // 
            // btn55Mph
            // 
            this.btn55Mph.Location = new System.Drawing.Point(39, 251);
            this.btn55Mph.Name = "btn55Mph";
            this.btn55Mph.Size = new System.Drawing.Size(113, 51);
            this.btn55Mph.TabIndex = 4;
            this.btn55Mph.Text = "&55 MPH";
            this.btn55Mph.UseVisualStyleBackColor = true;
            this.btn55Mph.Click += new System.EventHandler(this.btn55Mph_Click);
            // 
            // btn75Mph
            // 
            this.btn75Mph.Location = new System.Drawing.Point(195, 251);
            this.btn75Mph.Name = "btn75Mph";
            this.btn75Mph.Size = new System.Drawing.Size(113, 51);
            this.btn75Mph.TabIndex = 5;
            this.btn75Mph.Text = "&75 MPH";
            this.btn75Mph.UseVisualStyleBackColor = true;
            this.btn75Mph.Click += new System.EventHandler(this.btn75Mph_Click);
            // 
            // btn95Mph
            // 
            this.btn95Mph.Location = new System.Drawing.Point(351, 250);
            this.btn95Mph.Name = "btn95Mph";
            this.btn95Mph.Size = new System.Drawing.Size(113, 51);
            this.btn95Mph.TabIndex = 6;
            this.btn95Mph.Text = "&95 MPH";
            this.btn95Mph.UseVisualStyleBackColor = true;
            this.btn95Mph.Click += new System.EventHandler(this.btn95Mph_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(507, 251);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(113, 51);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(663, 249);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 51);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 353);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn95Mph);
            this.Controls.Add(this.btn75Mph);
            this.Controls.Add(this.btn55Mph);
            this.Controls.Add(this.tbxHoursOnTrain);
            this.Controls.Add(this.lblOutputDistanceTraveled);
            this.Controls.Add(this.lblDistanceTraveled);
            this.Controls.Add(this.lblHoursOnTrain);
            this.Name = "frmMain";
            this.Text = "Distance Traveled";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHoursOnTrain;
        private System.Windows.Forms.Label lblDistanceTraveled;
        private System.Windows.Forms.Label lblOutputDistanceTraveled;
        private System.Windows.Forms.TextBox tbxHoursOnTrain;
        private System.Windows.Forms.Button btn55Mph;
        private System.Windows.Forms.Button btn75Mph;
        private System.Windows.Forms.Button btn95Mph;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

