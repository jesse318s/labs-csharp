
namespace JesseSites3C
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
            this.lbxCruiseInput = new System.Windows.Forms.ListBox();
            this.lbxLocationInput = new System.Windows.Forms.ListBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCruiseOutput = new System.Windows.Forms.Label();
            this.lblCruise = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxCruiseInput
            // 
            this.lbxCruiseInput.FormattingEnabled = true;
            this.lbxCruiseInput.ItemHeight = 15;
            this.lbxCruiseInput.Items.AddRange(new object[] {
            "Carnival (Galveston)\t\t3\t\t$1,000",
            "Disney (Miami)\t\t7\t\t$2,000",
            "Princess (Seattle)\t\t4\t\t$1,500",
            "Royal Caribbean (San Diego)\t5\t\t$2,500",
            "Norwegian (New Orleans)\t8\t\t$5,000"});
            this.lbxCruiseInput.Location = new System.Drawing.Point(12, 37);
            this.lbxCruiseInput.Name = "lbxCruiseInput";
            this.lbxCruiseInput.Size = new System.Drawing.Size(326, 79);
            this.lbxCruiseInput.TabIndex = 0;
            // 
            // lbxLocationInput
            // 
            this.lbxLocationInput.FormattingEnabled = true;
            this.lbxLocationInput.ItemHeight = 15;
            this.lbxLocationInput.Items.AddRange(new object[] {
            "Jamaica\t\t$250",
            "Hawaii\t\t$325",
            "Caribbean\t$175",
            "Baja\t\t$300",
            "Panama Canal \t$575",
            "Alaska\t\t$150"});
            this.lbxLocationInput.Location = new System.Drawing.Point(382, 33);
            this.lbxLocationInput.Name = "lbxLocationInput";
            this.lbxLocationInput.Size = new System.Drawing.Size(184, 94);
            this.lbxLocationInput.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(382, 146);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(382, 227);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCruiseOutput
            // 
            this.lblCruiseOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCruiseOutput.Location = new System.Drawing.Point(12, 133);
            this.lblCruiseOutput.Name = "lblCruiseOutput";
            this.lblCruiseOutput.Size = new System.Drawing.Size(326, 123);
            this.lblCruiseOutput.TabIndex = 4;
            // 
            // lblCruise
            // 
            this.lblCruise.AutoSize = true;
            this.lblCruise.Location = new System.Drawing.Point(12, 12);
            this.lblCruise.Name = "lblCruise";
            this.lblCruise.Size = new System.Drawing.Size(326, 15);
            this.lblCruise.TabIndex = 5;
            this.lblCruise.Text = "Cruise Line (Departure City) / Number of Nights / Initial Cost";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(382, 12);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(187, 15);
            this.lblLocation.TabIndex = 6;
            this.lblLocation.Text = "Location / Lodging Fees per Night";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 287);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblCruise);
            this.Controls.Add(this.lblCruiseOutput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lbxLocationInput);
            this.Controls.Add(this.lbxCruiseInput);
            this.Name = "frmMain";
            this.Text = "Cruise Packages Selector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCruiseInput;
        private System.Windows.Forms.ListBox lbxLocationInput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCruiseOutput;
        private System.Windows.Forms.Label lblCruise;
        private System.Windows.Forms.Label lblLocation;
    }
}

