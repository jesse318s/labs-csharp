
namespace JesseSites3A
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
            this.lblIntegerDescription = new System.Windows.Forms.Label();
            this.tbxIntegerInput = new System.Windows.Forms.TextBox();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.lblSpanish = new System.Windows.Forms.Label();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.lblEnglishOutput = new System.Windows.Forms.Label();
            this.lblSpanishOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIntegerDescription
            // 
            this.lblIntegerDescription.AutoSize = true;
            this.lblIntegerDescription.Location = new System.Drawing.Point(25, 27);
            this.lblIntegerDescription.Name = "lblIntegerDescription";
            this.lblIntegerDescription.Size = new System.Drawing.Size(188, 15);
            this.lblIntegerDescription.TabIndex = 0;
            this.lblIntegerDescription.Text = "Enter an integer between 1 and 10:";
            // 
            // tbxIntegerInput
            // 
            this.tbxIntegerInput.Location = new System.Drawing.Point(250, 24);
            this.tbxIntegerInput.Name = "tbxIntegerInput";
            this.tbxIntegerInput.Size = new System.Drawing.Size(84, 23);
            this.tbxIntegerInput.TabIndex = 1;
            // 
            // lblEnglish
            // 
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.Location = new System.Drawing.Point(58, 64);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(45, 15);
            this.lblEnglish.TabIndex = 2;
            this.lblEnglish.Text = "English";
            // 
            // lblSpanish
            // 
            this.lblSpanish.AutoSize = true;
            this.lblSpanish.Location = new System.Drawing.Point(259, 64);
            this.lblSpanish.Name = "lblSpanish";
            this.lblSpanish.Size = new System.Drawing.Size(48, 15);
            this.lblSpanish.TabIndex = 3;
            this.lblSpanish.Text = "Spanish";
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(138, 158);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(75, 23);
            this.btnTranslate.TabIndex = 6;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // lblEnglishOutput
            // 
            this.lblEnglishOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEnglishOutput.Location = new System.Drawing.Point(30, 100);
            this.lblEnglishOutput.Name = "lblEnglishOutput";
            this.lblEnglishOutput.Size = new System.Drawing.Size(100, 23);
            this.lblEnglishOutput.TabIndex = 7;
            // 
            // lblSpanishOutput
            // 
            this.lblSpanishOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSpanishOutput.Location = new System.Drawing.Point(234, 100);
            this.lblSpanishOutput.Name = "lblSpanishOutput";
            this.lblSpanishOutput.Size = new System.Drawing.Size(100, 23);
            this.lblSpanishOutput.TabIndex = 8;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 214);
            this.Controls.Add(this.lblSpanishOutput);
            this.Controls.Add(this.lblEnglishOutput);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.lblSpanish);
            this.Controls.Add(this.lblEnglish);
            this.Controls.Add(this.tbxIntegerInput);
            this.Controls.Add(this.lblIntegerDescription);
            this.Name = "frmMain";
            this.Text = "English and Spanish Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIntegerDescription;
        private System.Windows.Forms.TextBox tbxIntegerInput;
        private System.Windows.Forms.Label lblEnglish;
        private System.Windows.Forms.Label lblSpanish;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Label lblEnglishOutput;
        private System.Windows.Forms.Label lblSpanishOutput;
    }
}

