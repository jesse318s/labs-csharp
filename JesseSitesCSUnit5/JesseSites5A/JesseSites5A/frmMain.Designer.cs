
namespace JesseSites5A
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCost = new System.Windows.Forms.Label();
            this.lblSales = new System.Windows.Forms.Label();
            this.lblSavings = new System.Windows.Forms.Label();
            this.lblSavingsOutput = new System.Windows.Forms.Label();
            this.lblSalesPriceOutput = new System.Windows.Forms.Label();
            this.tbxSalesInput = new System.Windows.Forms.TextBox();
            this.tbxCostInput = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(18, 23);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(116, 20);
            this.lblCost.TabIndex = 0;
            this.lblCost.Text = "Regular cost:";
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSales.Location = new System.Drawing.Point(16, 93);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(187, 20);
            this.lblSales.TabIndex = 1;
            this.lblSales.Text = "Sales percentage (%):";
            // 
            // lblSavings
            // 
            this.lblSavings.AutoSize = true;
            this.lblSavings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSavings.Location = new System.Drawing.Point(16, 171);
            this.lblSavings.Name = "lblSavings";
            this.lblSavings.Size = new System.Drawing.Size(77, 20);
            this.lblSavings.TabIndex = 2;
            this.lblSavings.Text = "Savings:";
            // 
            // lblSavingsOutput
            // 
            this.lblSavingsOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSavingsOutput.Location = new System.Drawing.Point(274, 153);
            this.lblSavingsOutput.Name = "lblSavingsOutput";
            this.lblSavingsOutput.Size = new System.Drawing.Size(142, 38);
            this.lblSavingsOutput.TabIndex = 3;
            // 
            // lblSalesPriceOutput
            // 
            this.lblSalesPriceOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalesPriceOutput.Location = new System.Drawing.Point(20, 223);
            this.lblSalesPriceOutput.Name = "lblSalesPriceOutput";
            this.lblSalesPriceOutput.Size = new System.Drawing.Size(396, 48);
            this.lblSalesPriceOutput.TabIndex = 4;
            // 
            // tbxSalesInput
            // 
            this.tbxSalesInput.Location = new System.Drawing.Point(274, 76);
            this.tbxSalesInput.Multiline = true;
            this.tbxSalesInput.Name = "tbxSalesInput";
            this.tbxSalesInput.Size = new System.Drawing.Size(137, 37);
            this.tbxSalesInput.TabIndex = 6;
            // 
            // tbxCostInput
            // 
            this.tbxCostInput.Location = new System.Drawing.Point(274, 23);
            this.tbxCostInput.Multiline = true;
            this.tbxCostInput.Name = "tbxCostInput";
            this.tbxCostInput.Size = new System.Drawing.Size(137, 32);
            this.tbxCostInput.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(31, 297);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(103, 36);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(163, 297);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 37);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(303, 297);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 36);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 356);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tbxCostInput);
            this.Controls.Add(this.tbxSalesInput);
            this.Controls.Add(this.lblSalesPriceOutput);
            this.Controls.Add(this.lblSavingsOutput);
            this.Controls.Add(this.lblSavings);
            this.Controls.Add(this.lblSales);
            this.Controls.Add(this.lblCost);
            this.Name = "frmMain";
            this.Text = "Sale Price Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.Label lblSavings;
        private System.Windows.Forms.Label lblSavingsOutput;
        private System.Windows.Forms.Label lblSalesPriceOutput;
        private System.Windows.Forms.TextBox tbxSalesInput;
        private System.Windows.Forms.TextBox tbxCostInput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

