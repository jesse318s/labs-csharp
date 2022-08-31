
namespace JesseSites4D
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
            this.lblFileContents = new System.Windows.Forms.Label();
            this.lbxNames = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblFileContents
            // 
            this.lblFileContents.AutoSize = true;
            this.lblFileContents.Location = new System.Drawing.Point(21, 16);
            this.lblFileContents.Name = "lblFileContents";
            this.lblFileContents.Size = new System.Drawing.Size(203, 15);
            this.lblFileContents.TabIndex = 0;
            this.lblFileContents.Text = "The following are contents of the file.";
            // 
            // lbxNames
            // 
            this.lbxNames.FormattingEnabled = true;
            this.lbxNames.ItemHeight = 15;
            this.lbxNames.Location = new System.Drawing.Point(21, 49);
            this.lbxNames.Name = "lbxNames";
            this.lbxNames.Size = new System.Drawing.Size(289, 259);
            this.lbxNames.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 329);
            this.Controls.Add(this.lbxNames);
            this.Controls.Add(this.lblFileContents);
            this.Name = "frmMain";
            this.Text = "Name Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFileContents;
        private System.Windows.Forms.ListBox lbxNames;
    }
}

