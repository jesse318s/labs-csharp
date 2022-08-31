
namespace JesseSites7B
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.lblProgramInfo = new System.Windows.Forms.Label();
            this.pbxProgramIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProgramIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProgramInfo
            // 
            this.lblProgramInfo.AutoSize = true;
            this.lblProgramInfo.Location = new System.Drawing.Point(22, 143);
            this.lblProgramInfo.Name = "lblProgramInfo";
            this.lblProgramInfo.Size = new System.Drawing.Size(374, 60);
            this.lblProgramInfo.TabIndex = 0;
            this.lblProgramInfo.Text = "Programmer Name: Jesse Sites\r\nDate: 6/11/2021\r\nDescription of Project: Movie Menu" +
    " with Custom Colors";
            // 
            // pbxProgramIcon
            // 
            this.pbxProgramIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxProgramIcon.BackgroundImage")));
            this.pbxProgramIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxProgramIcon.Location = new System.Drawing.Point(147, 13);
            this.pbxProgramIcon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbxProgramIcon.Name = "pbxProgramIcon";
            this.pbxProgramIcon.Size = new System.Drawing.Size(121, 93);
            this.pbxProgramIcon.TabIndex = 1;
            this.pbxProgramIcon.TabStop = false;
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 239);
            this.Controls.Add(this.pbxProgramIcon);
            this.Controls.Add(this.lblProgramInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAbout";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pbxProgramIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProgramInfo;
        private System.Windows.Forms.PictureBox pbxProgramIcon;
    }
}