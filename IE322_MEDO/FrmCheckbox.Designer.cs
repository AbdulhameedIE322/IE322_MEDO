namespace IE322_MEDO
{
    partial class FrmCheckbox
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
            this.btnShow = new System.Windows.Forms.Button();
            this.chkCoffee = new System.Windows.Forms.CheckBox();
            this.chkDonut = new System.Windows.Forms.CheckBox();
            this.chkBrownei = new System.Windows.Forms.CheckBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(12, 12);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // chkCoffee
            // 
            this.chkCoffee.AutoSize = true;
            this.chkCoffee.Location = new System.Drawing.Point(41, 68);
            this.chkCoffee.Name = "chkCoffee";
            this.chkCoffee.Size = new System.Drawing.Size(59, 17);
            this.chkCoffee.TabIndex = 1;
            this.chkCoffee.Text = "Coffee";
            this.chkCoffee.UseVisualStyleBackColor = true;
            this.chkCoffee.CheckedChanged += new System.EventHandler(this.chkCoffee_CheckedChanged);
            // 
            // chkDonut
            // 
            this.chkDonut.AutoSize = true;
            this.chkDonut.Location = new System.Drawing.Point(41, 112);
            this.chkDonut.Name = "chkDonut";
            this.chkDonut.Size = new System.Drawing.Size(55, 17);
            this.chkDonut.TabIndex = 2;
            this.chkDonut.Text = "Donut";
            this.chkDonut.UseVisualStyleBackColor = true;
            // 
            // chkBrownei
            // 
            this.chkBrownei.AutoSize = true;
            this.chkBrownei.Location = new System.Drawing.Point(41, 158);
            this.chkBrownei.Name = "chkBrownei";
            this.chkBrownei.Size = new System.Drawing.Size(64, 17);
            this.chkBrownei.TabIndex = 3;
            this.chkBrownei.Text = "Brownei";
            this.chkBrownei.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(219, 224);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmCheckbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 254);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.chkBrownei);
            this.Controls.Add(this.chkDonut);
            this.Controls.Add(this.chkCoffee);
            this.Controls.Add(this.btnShow);
            this.Name = "FrmCheckbox";
            this.Text = "Checkbox Form";
            this.Load += new System.EventHandler(this.FrmCheckbox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.CheckBox chkCoffee;
        private System.Windows.Forms.CheckBox chkDonut;
        private System.Windows.Forms.CheckBox chkBrownei;
        private System.Windows.Forms.Button btnBack;
    }
}