
namespace JesseSites6A
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
            this.lbxValues = new System.Windows.Forms.ListBox();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalOutput = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblAverageOutput = new System.Windows.Forms.Label();
            this.lblLargest = new System.Windows.Forms.Label();
            this.lblLargestOutput = new System.Windows.Forms.Label();
            this.lblSmallest = new System.Windows.Forms.Label();
            this.lblSmallestOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxValues
            // 
            this.lbxValues.FormattingEnabled = true;
            this.lbxValues.ItemHeight = 15;
            this.lbxValues.Location = new System.Drawing.Point(22, 28);
            this.lbxValues.Name = "lbxValues";
            this.lbxValues.Size = new System.Drawing.Size(183, 154);
            this.lbxValues.TabIndex = 0;
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(57, 205);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(75, 23);
            this.btnSales.TabIndex = 1;
            this.btnSales.Text = "&Sales";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(341, 205);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(261, 38);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(82, 15);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total of Values";
            // 
            // lblTotalOutput
            // 
            this.lblTotalOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalOutput.Location = new System.Drawing.Point(382, 37);
            this.lblTotalOutput.Name = "lblTotalOutput";
            this.lblTotalOutput.Size = new System.Drawing.Size(88, 16);
            this.lblTotalOutput.TabIndex = 4;
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(261, 79);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(100, 15);
            this.lblAverage.TabIndex = 5;
            this.lblAverage.Text = "Average of Values";
            // 
            // lblAverageOutput
            // 
            this.lblAverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAverageOutput.Location = new System.Drawing.Point(382, 78);
            this.lblAverageOutput.Name = "lblAverageOutput";
            this.lblAverageOutput.Size = new System.Drawing.Size(88, 15);
            this.lblAverageOutput.TabIndex = 6;
            // 
            // lblLargest
            // 
            this.lblLargest.AutoSize = true;
            this.lblLargest.Location = new System.Drawing.Point(261, 120);
            this.lblLargest.Name = "lblLargest";
            this.lblLargest.Size = new System.Drawing.Size(76, 15);
            this.lblLargest.TabIndex = 7;
            this.lblLargest.Text = "Largest Value";
            // 
            // lblLargestOutput
            // 
            this.lblLargestOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLargestOutput.Location = new System.Drawing.Point(382, 120);
            this.lblLargestOutput.Name = "lblLargestOutput";
            this.lblLargestOutput.Size = new System.Drawing.Size(88, 15);
            this.lblLargestOutput.TabIndex = 8;
            // 
            // lblSmallest
            // 
            this.lblSmallest.AutoSize = true;
            this.lblSmallest.Location = new System.Drawing.Point(261, 161);
            this.lblSmallest.Name = "lblSmallest";
            this.lblSmallest.Size = new System.Drawing.Size(82, 15);
            this.lblSmallest.TabIndex = 9;
            this.lblSmallest.Text = "Smallest Value";
            // 
            // lblSmallestOutput
            // 
            this.lblSmallestOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSmallestOutput.Location = new System.Drawing.Point(382, 161);
            this.lblSmallestOutput.Name = "lblSmallestOutput";
            this.lblSmallestOutput.Size = new System.Drawing.Size(88, 15);
            this.lblSmallestOutput.TabIndex = 10;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 245);
            this.Controls.Add(this.lblSmallestOutput);
            this.Controls.Add(this.lblSmallest);
            this.Controls.Add(this.lblLargestOutput);
            this.Controls.Add(this.lblLargest);
            this.Controls.Add(this.lblAverageOutput);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblTotalOutput);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.lbxValues);
            this.Name = "frmMain";
            this.Text = "Sales Analysis";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxValues;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalOutput;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblAverageOutput;
        private System.Windows.Forms.Label lblLargest;
        private System.Windows.Forms.Label lblLargestOutput;
        private System.Windows.Forms.Label lblSmallest;
        private System.Windows.Forms.Label lblSmallestOutput;
    }
}

