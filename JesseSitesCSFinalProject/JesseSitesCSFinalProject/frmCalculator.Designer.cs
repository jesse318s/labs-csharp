
namespace JesseSitesCSFinalProject
{
    partial class frmCalculator
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
            this.btnClose = new System.Windows.Forms.Button();
            this.tbxNum2Input = new System.Windows.Forms.TextBox();
            this.tbxNum1Input = new System.Windows.Forms.TextBox();
            this.tbxOperandInput = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblOperand = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblResultOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(398, 210);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbxNum2Input
            // 
            this.tbxNum2Input.Location = new System.Drawing.Point(215, 107);
            this.tbxNum2Input.Name = "tbxNum2Input";
            this.tbxNum2Input.Size = new System.Drawing.Size(109, 23);
            this.tbxNum2Input.TabIndex = 2;
            // 
            // tbxNum1Input
            // 
            this.tbxNum1Input.Location = new System.Drawing.Point(12, 107);
            this.tbxNum1Input.Name = "tbxNum1Input";
            this.tbxNum1Input.Size = new System.Drawing.Size(101, 23);
            this.tbxNum1Input.TabIndex = 3;
            // 
            // tbxOperandInput
            // 
            this.tbxOperandInput.Location = new System.Drawing.Point(139, 107);
            this.tbxOperandInput.Name = "tbxOperandInput";
            this.tbxOperandInput.Size = new System.Drawing.Size(39, 23);
            this.tbxOperandInput.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(196, 210);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 210);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "C&alculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblOperand
            // 
            this.lblOperand.AutoSize = true;
            this.lblOperand.Location = new System.Drawing.Point(118, 75);
            this.lblOperand.Name = "lblOperand";
            this.lblOperand.Size = new System.Drawing.Size(88, 15);
            this.lblOperand.TabIndex = 7;
            this.lblOperand.Text = "Operand(+,-,*):";
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(44, 75);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(43, 15);
            this.lblNum1.TabIndex = 8;
            this.lblNum1.Text = "Num1:";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(248, 75);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(43, 15);
            this.lblNum2.TabIndex = 9;
            this.lblNum2.Text = "Num2:";
            // 
            // lblResultOutput
            // 
            this.lblResultOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultOutput.Location = new System.Drawing.Point(330, 107);
            this.lblResultOutput.Name = "lblResultOutput";
            this.lblResultOutput.Size = new System.Drawing.Size(143, 23);
            this.lblResultOutput.TabIndex = 10;
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 245);
            this.Controls.Add(this.lblResultOutput);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.lblOperand);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbxOperandInput);
            this.Controls.Add(this.tbxNum1Input);
            this.Controls.Add(this.tbxNum2Input);
            this.Controls.Add(this.btnClose);
            this.Name = "frmCalculator";
            this.Text = "Fun Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbxNum2Input;
        private System.Windows.Forms.TextBox tbxNum1Input;
        private System.Windows.Forms.TextBox tbxOperandInput;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblOperand;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblResultOutput;
    }
}