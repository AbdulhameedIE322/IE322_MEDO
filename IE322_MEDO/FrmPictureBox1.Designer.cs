namespace IE322_MEDO
{
    partial class FrmPictureBox1
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
            this.BtnLoadimage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLoadimage
            // 
            this.BtnLoadimage.Location = new System.Drawing.Point(12, 12);
            this.BtnLoadimage.Name = "BtnLoadimage";
            this.BtnLoadimage.Size = new System.Drawing.Size(354, 71);
            this.BtnLoadimage.TabIndex = 0;
            this.BtnLoadimage.Text = "Load image";
            this.BtnLoadimage.UseVisualStyleBackColor = true;
            this.BtnLoadimage.Click += new System.EventHandler(this.BtnLoadimage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 345);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPictureBox1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 483);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnLoadimage);
            this.Name = "FrmPictureBox1";
            this.Text = "FrmPictureBox1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLoadimage;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}