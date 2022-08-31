
namespace JesseSites4B
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
            this.lblStartingAmount = new System.Windows.Forms.Label();
            this.lblMonthlyIncrease = new System.Windows.Forms.Label();
            this.lblMonthsNumber = new System.Windows.Forms.Label();
            this.tbxStartingAmountInput = new System.Windows.Forms.TextBox();
            this.tbxMonthlyIncreaseInput = new System.Windows.Forms.TextBox();
            this.tbxMonthsNumberInput = new System.Windows.Forms.TextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lbxSavings = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblStartingAmount
            // 
            this.lblStartingAmount.AutoSize = true;
            this.lblStartingAmount.Location = new System.Drawing.Point(76, 22);
            this.lblStartingAmount.Name = "lblStartingAmount";
            this.lblStartingAmount.Size = new System.Drawing.Size(205, 15);
            this.lblStartingAmount.TabIndex = 0;
            this.lblStartingAmount.Text = "Starting amount of money in savings:";
            // 
            // lblMonthlyIncrease
            // 
            this.lblMonthlyIncrease.AutoSize = true;
            this.lblMonthlyIncrease.Location = new System.Drawing.Point(113, 61);
            this.lblMonthlyIncrease.Name = "lblMonthlyIncrease";
            this.lblMonthlyIncrease.Size = new System.Drawing.Size(168, 15);
            this.lblMonthlyIncrease.TabIndex = 1;
            this.lblMonthlyIncrease.Text = "Average monthly increase (%):";
            // 
            // lblMonthsNumber
            // 
            this.lblMonthsNumber.AutoSize = true;
            this.lblMonthsNumber.Location = new System.Drawing.Point(108, 94);
            this.lblMonthsNumber.Name = "lblMonthsNumber";
            this.lblMonthsNumber.Size = new System.Drawing.Size(173, 15);
            this.lblMonthsNumber.TabIndex = 2;
            this.lblMonthsNumber.Text = "Number of months to multiply:";
            // 
            // tbxStartingAmountInput
            // 
            this.tbxStartingAmountInput.Location = new System.Drawing.Point(301, 22);
            this.tbxStartingAmountInput.Name = "tbxStartingAmountInput";
            this.tbxStartingAmountInput.Size = new System.Drawing.Size(100, 23);
            this.tbxStartingAmountInput.TabIndex = 3;
            // 
            // tbxMonthlyIncreaseInput
            // 
            this.tbxMonthlyIncreaseInput.Location = new System.Drawing.Point(301, 56);
            this.tbxMonthlyIncreaseInput.Name = "tbxMonthlyIncreaseInput";
            this.tbxMonthlyIncreaseInput.Size = new System.Drawing.Size(100, 23);
            this.tbxMonthlyIncreaseInput.TabIndex = 4;
            // 
            // tbxMonthsNumberInput
            // 
            this.tbxMonthsNumberInput.Location = new System.Drawing.Point(301, 91);
            this.tbxMonthsNumberInput.Name = "tbxMonthsNumberInput";
            this.tbxMonthsNumberInput.Size = new System.Drawing.Size(100, 23);
            this.tbxMonthsNumberInput.TabIndex = 5;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(326, 120);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 6;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lbxSavings
            // 
            this.lbxSavings.FormattingEnabled = true;
            this.lbxSavings.ItemHeight = 15;
            this.lbxSavings.Location = new System.Drawing.Point(23, 149);
            this.lbxSavings.Name = "lbxSavings";
            this.lbxSavings.Size = new System.Drawing.Size(378, 244);
            this.lbxSavings.TabIndex = 7;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 413);
            this.Controls.Add(this.lbxSavings);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.tbxMonthsNumberInput);
            this.Controls.Add(this.tbxMonthlyIncreaseInput);
            this.Controls.Add(this.tbxStartingAmountInput);
            this.Controls.Add(this.lblMonthsNumber);
            this.Controls.Add(this.lblMonthlyIncrease);
            this.Controls.Add(this.lblStartingAmount);
            this.Name = "frmMain";
            this.Text = "Savings Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStartingAmount;
        private System.Windows.Forms.Label lblMonthlyIncrease;
        private System.Windows.Forms.Label lblMonthsNumber;
        private System.Windows.Forms.TextBox tbxStartingAmountInput;
        private System.Windows.Forms.TextBox tbxMonthlyIncreaseInput;
        private System.Windows.Forms.TextBox tbxMonthsNumberInput;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.ListBox lbxSavings;
    }
}

