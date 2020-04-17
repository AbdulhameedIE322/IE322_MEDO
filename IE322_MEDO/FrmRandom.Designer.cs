namespace IE322_MEDO
{
    partial class FrmRandom
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
            this.BtnGenerateRandomColor = new System.Windows.Forms.Button();
            this.LblRgb = new System.Windows.Forms.Label();
            this.BtnRandomNumber = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGenerateRandomColor
            // 
            this.BtnGenerateRandomColor.Location = new System.Drawing.Point(12, 50);
            this.BtnGenerateRandomColor.Name = "BtnGenerateRandomColor";
            this.BtnGenerateRandomColor.Size = new System.Drawing.Size(371, 65);
            this.BtnGenerateRandomColor.TabIndex = 0;
            this.BtnGenerateRandomColor.Text = "Generate Random Color";
            this.BtnGenerateRandomColor.UseVisualStyleBackColor = true;
            this.BtnGenerateRandomColor.Click += new System.EventHandler(this.BtnGenerateRandomColor_Click);
            // 
            // LblRgb
            // 
            this.LblRgb.AutoSize = true;
            this.LblRgb.Location = new System.Drawing.Point(163, 148);
            this.LblRgb.Name = "LblRgb";
            this.LblRgb.Size = new System.Drawing.Size(65, 13);
            this.LblRgb.TabIndex = 1;
            this.LblRgb.Text = "     R-G-B     ";
            this.LblRgb.Click += new System.EventHandler(this.LblRgb_Click);
            // 
            // BtnRandomNumber
            // 
            this.BtnRandomNumber.Location = new System.Drawing.Point(46, 187);
            this.BtnRandomNumber.Name = "BtnRandomNumber";
            this.BtnRandomNumber.Size = new System.Drawing.Size(120, 50);
            this.BtnRandomNumber.TabIndex = 2;
            this.BtnRandomNumber.Text = "Random Number";
            this.BtnRandomNumber.UseVisualStyleBackColor = true;
            this.BtnRandomNumber.Click += new System.EventHandler(this.BtnRandomNumber_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(213, 187);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(120, 50);
            this.BtnBack.TabIndex = 3;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // FrmRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 279);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnRandomNumber);
            this.Controls.Add(this.LblRgb);
            this.Controls.Add(this.BtnGenerateRandomColor);
            this.Name = "FrmRandom";
            this.Text = "Random";
            this.Load += new System.EventHandler(this.Random_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGenerateRandomColor;
        private System.Windows.Forms.Label LblRgb;
        private System.Windows.Forms.Button BtnRandomNumber;
        private System.Windows.Forms.Button BtnBack;
    }
}