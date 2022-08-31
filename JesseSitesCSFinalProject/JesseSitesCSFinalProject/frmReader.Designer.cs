
namespace JesseSitesCSFinalProject
{
    partial class frmReader
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
            this.lbxGrades = new System.Windows.Forms.ListBox();
            this.btnGrades = new System.Windows.Forms.Button();
            this.lblTotalOutput = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblLetters = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblAverageOutput = new System.Windows.Forms.Label();
            this.lblLettersOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(259, 215);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbxGrades
            // 
            this.lbxGrades.FormattingEnabled = true;
            this.lbxGrades.ItemHeight = 15;
            this.lbxGrades.Location = new System.Drawing.Point(12, 12);
            this.lbxGrades.Name = "lbxGrades";
            this.lbxGrades.Size = new System.Drawing.Size(163, 184);
            this.lbxGrades.TabIndex = 2;
            // 
            // btnGrades
            // 
            this.btnGrades.Location = new System.Drawing.Point(48, 215);
            this.btnGrades.Name = "btnGrades";
            this.btnGrades.Size = new System.Drawing.Size(75, 23);
            this.btnGrades.TabIndex = 3;
            this.btnGrades.Text = "&Grades";
            this.btnGrades.UseVisualStyleBackColor = true;
            this.btnGrades.Click += new System.EventHandler(this.btnGrades_Click);
            // 
            // lblTotalOutput
            // 
            this.lblTotalOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalOutput.Location = new System.Drawing.Point(288, 12);
            this.lblTotalOutput.Name = "lblTotalOutput";
            this.lblTotalOutput.Size = new System.Drawing.Size(58, 23);
            this.lblTotalOutput.TabIndex = 4;
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(215, 49);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(53, 15);
            this.lblAverage.TabIndex = 5;
            this.lblAverage.Text = "Average:";
            // 
            // lblLetters
            // 
            this.lblLetters.AutoSize = true;
            this.lblLetters.Location = new System.Drawing.Point(215, 85);
            this.lblLetters.Name = "lblLetters";
            this.lblLetters.Size = new System.Drawing.Size(45, 15);
            this.lblLetters.TabIndex = 6;
            this.lblLetters.Text = "Letters:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(215, 12);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 15);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total:";
            // 
            // lblAverageOutput
            // 
            this.lblAverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAverageOutput.Location = new System.Drawing.Point(288, 42);
            this.lblAverageOutput.Name = "lblAverageOutput";
            this.lblAverageOutput.Size = new System.Drawing.Size(58, 22);
            this.lblAverageOutput.TabIndex = 8;
            // 
            // lblLettersOutput
            // 
            this.lblLettersOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLettersOutput.Location = new System.Drawing.Point(288, 73);
            this.lblLettersOutput.Name = "lblLettersOutput";
            this.lblLettersOutput.Size = new System.Drawing.Size(58, 123);
            this.lblLettersOutput.TabIndex = 9;
            // 
            // frmReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 268);
            this.Controls.Add(this.lblLettersOutput);
            this.Controls.Add(this.lblAverageOutput);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblLetters);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblTotalOutput);
            this.Controls.Add(this.btnGrades);
            this.Controls.Add(this.lbxGrades);
            this.Controls.Add(this.btnClose);
            this.Name = "frmReader";
            this.Text = "Read It";
            this.Load += new System.EventHandler(this.frmReader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lbxGrades;
        private System.Windows.Forms.Button btnGrades;
        private System.Windows.Forms.Label lblTotalOutput;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblLetters;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblAverageOutput;
        private System.Windows.Forms.Label lblLettersOutput;
    }
}