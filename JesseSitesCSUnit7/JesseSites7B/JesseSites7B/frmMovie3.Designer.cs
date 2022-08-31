
namespace JesseSites7B
{
    partial class frmMovie3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovie3));
            this.lblMovieDesc = new System.Windows.Forms.Label();
            this.pbxMovie = new System.Windows.Forms.PictureBox();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMovieDesc
            // 
            this.lblMovieDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMovieDesc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMovieDesc.Location = new System.Drawing.Point(13, 15);
            this.lblMovieDesc.Name = "lblMovieDesc";
            this.lblMovieDesc.Size = new System.Drawing.Size(439, 198);
            this.lblMovieDesc.TabIndex = 0;
            this.lblMovieDesc.Text = "Movie Name: The Matrix Revolutions\r\n\r\nYear Released: 2003\r\n\r\nGenre: Sci-Fi\r\n\r\nMai" +
    "n Character: Neo";
            // 
            // pbxMovie
            // 
            this.pbxMovie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxMovie.BackgroundImage")));
            this.pbxMovie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxMovie.Location = new System.Drawing.Point(458, 14);
            this.pbxMovie.Name = "pbxMovie";
            this.pbxMovie.Size = new System.Drawing.Size(114, 199);
            this.pbxMovie.TabIndex = 1;
            this.pbxMovie.TabStop = false;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(458, 220);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(114, 41);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return To Main";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // frmMovie3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 278);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.pbxMovie);
            this.Controls.Add(this.lblMovieDesc);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "frmMovie3";
            this.Text = "Movie Three";
            ((System.ComponentModel.ISupportInitialize)(this.pbxMovie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMovieDesc;
        private System.Windows.Forms.PictureBox pbxMovie;
        private System.Windows.Forms.Button btnReturn;
    }
}