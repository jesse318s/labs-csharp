
namespace JesseSites7B
{
    partial class frmMovie1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovie1));
            this.btnReturn = new System.Windows.Forms.Button();
            this.pbxMovie = new System.Windows.Forms.PictureBox();
            this.lblMovieDesc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(451, 209);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(114, 41);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Return To Main";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pbxMovie
            // 
            this.pbxMovie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxMovie.BackgroundImage")));
            this.pbxMovie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxMovie.Location = new System.Drawing.Point(451, 3);
            this.pbxMovie.Name = "pbxMovie";
            this.pbxMovie.Size = new System.Drawing.Size(114, 199);
            this.pbxMovie.TabIndex = 7;
            this.pbxMovie.TabStop = false;
            // 
            // lblMovieDesc
            // 
            this.lblMovieDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMovieDesc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMovieDesc.Location = new System.Drawing.Point(6, 4);
            this.lblMovieDesc.Name = "lblMovieDesc";
            this.lblMovieDesc.Size = new System.Drawing.Size(439, 198);
            this.lblMovieDesc.TabIndex = 6;
            this.lblMovieDesc.Text = "Movie Name: The Matrix\r\n\r\nYear Released: 1999\r\n\r\nGenre: Sci-Fi\r\n\r\nMain Character:" +
    " Neo\r\n";
            // 
            // frmMovie1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 259);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.pbxMovie);
            this.Controls.Add(this.lblMovieDesc);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "frmMovie1";
            this.Text = "Movie One";
            ((System.ComponentModel.ISupportInitialize)(this.pbxMovie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.PictureBox pbxMovie;
        private System.Windows.Forms.Label lblMovieDesc;
    }
}