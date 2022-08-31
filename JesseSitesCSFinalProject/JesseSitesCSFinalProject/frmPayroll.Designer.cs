
namespace JesseSitesCSFinalProject
{
    partial class frmPayroll
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.blRateOfPay = new System.Windows.Forms.Label();
            this.tbxHoursWorkedInput = new System.Windows.Forms.TextBox();
            this.tbxRateOfPayInput = new System.Windows.Forms.TextBox();
            this.lbxEmployeeInfo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(223, 279);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(121, 279);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Tag = "";
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(21, 279);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "C&alculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Location = new System.Drawing.Point(40, 12);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(84, 15);
            this.lblHoursWorked.TabIndex = 4;
            this.lblHoursWorked.Text = "Hours worked:";
            // 
            // blRateOfPay
            // 
            this.blRateOfPay.AutoSize = true;
            this.blRateOfPay.Location = new System.Drawing.Point(169, 12);
            this.blRateOfPay.Name = "blRateOfPay";
            this.blRateOfPay.Size = new System.Drawing.Size(69, 15);
            this.blRateOfPay.TabIndex = 5;
            this.blRateOfPay.Text = "Rate of pay:";
            // 
            // tbxHoursWorkedInput
            // 
            this.tbxHoursWorkedInput.Location = new System.Drawing.Point(40, 30);
            this.tbxHoursWorkedInput.Name = "tbxHoursWorkedInput";
            this.tbxHoursWorkedInput.Size = new System.Drawing.Size(100, 23);
            this.tbxHoursWorkedInput.TabIndex = 6;
            // 
            // tbxRateOfPayInput
            // 
            this.tbxRateOfPayInput.Location = new System.Drawing.Point(169, 30);
            this.tbxRateOfPayInput.Name = "tbxRateOfPayInput";
            this.tbxRateOfPayInput.Size = new System.Drawing.Size(100, 23);
            this.tbxRateOfPayInput.TabIndex = 7;
            // 
            // lbxEmployeeInfo
            // 
            this.lbxEmployeeInfo.FormattingEnabled = true;
            this.lbxEmployeeInfo.ItemHeight = 15;
            this.lbxEmployeeInfo.Location = new System.Drawing.Point(40, 59);
            this.lbxEmployeeInfo.Name = "lbxEmployeeInfo";
            this.lbxEmployeeInfo.Size = new System.Drawing.Size(229, 199);
            this.lbxEmployeeInfo.TabIndex = 8;
            // 
            // frmPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 322);
            this.Controls.Add(this.lbxEmployeeInfo);
            this.Controls.Add(this.tbxRateOfPayInput);
            this.Controls.Add(this.tbxHoursWorkedInput);
            this.Controls.Add(this.blRateOfPay);
            this.Controls.Add(this.lblHoursWorked);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Name = "frmPayroll";
            this.Text = "Payroll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.Label blRateOfPay;
        private System.Windows.Forms.TextBox tbxHoursWorkedInput;
        private System.Windows.Forms.TextBox tbxRateOfPayInput;
        private System.Windows.Forms.ListBox lbxEmployeeInfo;
    }
}