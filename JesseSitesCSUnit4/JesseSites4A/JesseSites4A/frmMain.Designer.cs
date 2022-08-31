
namespace JesseSites4A
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
            this.lblTuitionPerHour = new System.Windows.Forms.Label();
            this.lblHoursSemester = new System.Windows.Forms.Label();
            this.tbxTuitionPerHourInput = new System.Windows.Forms.TextBox();
            this.tbxHoursSemesterInput = new System.Windows.Forms.TextBox();
            this.lbxCost = new System.Windows.Forms.ListBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTuitionPerHour
            // 
            this.lblTuitionPerHour.AutoSize = true;
            this.lblTuitionPerHour.Location = new System.Drawing.Point(32, 29);
            this.lblTuitionPerHour.Name = "lblTuitionPerHour";
            this.lblTuitionPerHour.Size = new System.Drawing.Size(121, 15);
            this.lblTuitionPerHour.TabIndex = 0;
            this.lblTuitionPerHour.Text = "Tuition Cost Per Hour";
            // 
            // lblHoursSemester
            // 
            this.lblHoursSemester.AutoSize = true;
            this.lblHoursSemester.Location = new System.Drawing.Point(32, 66);
            this.lblHoursSemester.Name = "lblHoursSemester";
            this.lblHoursSemester.Size = new System.Drawing.Size(108, 15);
            this.lblHoursSemester.TabIndex = 1;
            this.lblHoursSemester.Text = "Hours for Semester";
            // 
            // tbxTuitionPerHourInput
            // 
            this.tbxTuitionPerHourInput.Location = new System.Drawing.Point(189, 29);
            this.tbxTuitionPerHourInput.Name = "tbxTuitionPerHourInput";
            this.tbxTuitionPerHourInput.Size = new System.Drawing.Size(100, 23);
            this.tbxTuitionPerHourInput.TabIndex = 2;
            // 
            // tbxHoursSemesterInput
            // 
            this.tbxHoursSemesterInput.Location = new System.Drawing.Point(189, 66);
            this.tbxHoursSemesterInput.Name = "tbxHoursSemesterInput";
            this.tbxHoursSemesterInput.Size = new System.Drawing.Size(100, 23);
            this.tbxHoursSemesterInput.TabIndex = 3;
            // 
            // lbxCost
            // 
            this.lbxCost.FormattingEnabled = true;
            this.lbxCost.ItemHeight = 15;
            this.lbxCost.Location = new System.Drawing.Point(32, 107);
            this.lbxCost.Name = "lbxCost";
            this.lbxCost.Size = new System.Drawing.Size(260, 199);
            this.lbxCost.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(78, 345);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(168, 345);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 380);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lbxCost);
            this.Controls.Add(this.tbxHoursSemesterInput);
            this.Controls.Add(this.tbxTuitionPerHourInput);
            this.Controls.Add(this.lblHoursSemester);
            this.Controls.Add(this.lblTuitionPerHour);
            this.Name = "frmMain";
            this.Text = "Tuition Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTuitionPerHour;
        private System.Windows.Forms.Label lblHoursSemester;
        private System.Windows.Forms.TextBox tbxTuitionPerHourOutput;
        private System.Windows.Forms.TextBox tbxHoursSemesterInput;
        private System.Windows.Forms.ListBox lbxCost;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox tbxTuitionPerHourInput;
    }
}

