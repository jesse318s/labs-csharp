
namespace JesseSitesCSFinalProject
{
    partial class frmStringy
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
            this.tbxWordInput = new System.Windows.Forms.TextBox();
            this.lblWordInput = new System.Windows.Forms.Label();
            this.lblNewWord = new System.Windows.Forms.Label();
            this.lblNewWordOutput = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(302, 188);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbxWordInput
            // 
            this.tbxWordInput.Location = new System.Drawing.Point(175, 42);
            this.tbxWordInput.Name = "tbxWordInput";
            this.tbxWordInput.Size = new System.Drawing.Size(100, 23);
            this.tbxWordInput.TabIndex = 2;
            // 
            // lblWordInput
            // 
            this.lblWordInput.AutoSize = true;
            this.lblWordInput.Location = new System.Drawing.Point(59, 45);
            this.lblWordInput.Name = "lblWordInput";
            this.lblWordInput.Size = new System.Drawing.Size(104, 15);
            this.lblWordInput.TabIndex = 3;
            this.lblWordInput.Text = "Please input word:";
            // 
            // lblNewWord
            // 
            this.lblNewWord.AutoSize = true;
            this.lblNewWord.Location = new System.Drawing.Point(99, 104);
            this.lblNewWord.Name = "lblNewWord";
            this.lblNewWord.Size = new System.Drawing.Size(64, 15);
            this.lblNewWord.TabIndex = 4;
            this.lblNewWord.Text = "New word:";
            // 
            // lblNewWordOutput
            // 
            this.lblNewWordOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNewWordOutput.Location = new System.Drawing.Point(175, 95);
            this.lblNewWordOutput.Name = "lblNewWordOutput";
            this.lblNewWordOutput.Size = new System.Drawing.Size(100, 24);
            this.lblNewWordOutput.TabIndex = 5;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(12, 188);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "C&hange";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(155, 188);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmStringy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 223);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lblNewWordOutput);
            this.Controls.Add(this.lblNewWord);
            this.Controls.Add(this.lblWordInput);
            this.Controls.Add(this.tbxWordInput);
            this.Controls.Add(this.btnClose);
            this.Name = "frmStringy";
            this.Text = "Cheesy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbxWordInput;
        private System.Windows.Forms.Label lblWordInput;
        private System.Windows.Forms.Label lblNewWord;
        private System.Windows.Forms.Label lblNewWordOutput;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnClear;
    }
}