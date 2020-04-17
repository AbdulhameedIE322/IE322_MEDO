namespace IE322_MEDO
{
    partial class FrmRandomCom
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
            this.cmbRandom1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnGenerate1 = new System.Windows.Forms.Button();
            this.RdoLessthan500 = new System.Windows.Forms.RadioButton();
            this.RdoGreaterthan500 = new System.Windows.Forms.RadioButton();
            this.BtnReset1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnReset2 = new System.Windows.Forms.Button();
            this.RdoRdoGreaterthan50 = new System.Windows.Forms.RadioButton();
            this.RdoLessthan50 = new System.Windows.Forms.RadioButton();
            this.BtnGenerate2 = new System.Windows.Forms.Button();
            this.cmbRandom2 = new System.Windows.Forms.ComboBox();
            this.LblCount = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbRandom1
            // 
            this.cmbRandom1.FormattingEnabled = true;
            this.cmbRandom1.Location = new System.Drawing.Point(6, 36);
            this.cmbRandom1.Name = "cmbRandom1";
            this.cmbRandom1.Size = new System.Drawing.Size(121, 21);
            this.cmbRandom1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnReset1);
            this.groupBox1.Controls.Add(this.RdoGreaterthan500);
            this.groupBox1.Controls.Add(this.RdoLessthan500);
            this.groupBox1.Controls.Add(this.BtnGenerate1);
            this.groupBox1.Controls.Add(this.cmbRandom1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 199);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // BtnGenerate1
            // 
            this.BtnGenerate1.Location = new System.Drawing.Point(157, 36);
            this.BtnGenerate1.Name = "BtnGenerate1";
            this.BtnGenerate1.Size = new System.Drawing.Size(75, 23);
            this.BtnGenerate1.TabIndex = 1;
            this.BtnGenerate1.Text = "Generate";
            this.BtnGenerate1.UseVisualStyleBackColor = true;
            this.BtnGenerate1.Click += new System.EventHandler(this.BtnGenerate1_Click);
            // 
            // RdoLessthan500
            // 
            this.RdoLessthan500.AutoSize = true;
            this.RdoLessthan500.Location = new System.Drawing.Point(118, 101);
            this.RdoLessthan500.Name = "RdoLessthan500";
            this.RdoLessthan500.Size = new System.Drawing.Size(92, 17);
            this.RdoLessthan500.TabIndex = 2;
            this.RdoLessthan500.TabStop = true;
            this.RdoLessthan500.Text = "Less than 500";
            this.RdoLessthan500.UseVisualStyleBackColor = true;
            // 
            // RdoGreaterthan500
            // 
            this.RdoGreaterthan500.AutoSize = true;
            this.RdoGreaterthan500.Location = new System.Drawing.Point(118, 124);
            this.RdoGreaterthan500.Name = "RdoGreaterthan500";
            this.RdoGreaterthan500.Size = new System.Drawing.Size(108, 17);
            this.RdoGreaterthan500.TabIndex = 3;
            this.RdoGreaterthan500.TabStop = true;
            this.RdoGreaterthan500.Text = "Greater than 500";
            this.RdoGreaterthan500.UseVisualStyleBackColor = true;
            // 
            // BtnReset1
            // 
            this.BtnReset1.Location = new System.Drawing.Point(157, 159);
            this.BtnReset1.Name = "BtnReset1";
            this.BtnReset1.Size = new System.Drawing.Size(75, 23);
            this.BtnReset1.TabIndex = 4;
            this.BtnReset1.Text = "Reset";
            this.BtnReset1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblCount);
            this.groupBox2.Controls.Add(this.BtnReset2);
            this.groupBox2.Controls.Add(this.RdoRdoGreaterthan50);
            this.groupBox2.Controls.Add(this.RdoLessthan50);
            this.groupBox2.Controls.Add(this.BtnGenerate2);
            this.groupBox2.Controls.Add(this.cmbRandom2);
            this.groupBox2.Location = new System.Drawing.Point(344, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 199);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // BtnReset2
            // 
            this.BtnReset2.Location = new System.Drawing.Point(157, 159);
            this.BtnReset2.Name = "BtnReset2";
            this.BtnReset2.Size = new System.Drawing.Size(75, 23);
            this.BtnReset2.TabIndex = 4;
            this.BtnReset2.Text = "Reset";
            this.BtnReset2.UseVisualStyleBackColor = true;
            // 
            // RdoRdoGreaterthan50
            // 
            this.RdoRdoGreaterthan50.AutoSize = true;
            this.RdoRdoGreaterthan50.Location = new System.Drawing.Point(114, 124);
            this.RdoRdoGreaterthan50.Name = "RdoRdoGreaterthan50";
            this.RdoRdoGreaterthan50.Size = new System.Drawing.Size(102, 17);
            this.RdoRdoGreaterthan50.TabIndex = 3;
            this.RdoRdoGreaterthan50.TabStop = true;
            this.RdoRdoGreaterthan50.Text = "Greater than 50";
            this.RdoRdoGreaterthan50.UseVisualStyleBackColor = true;
            // 
            // RdoLessthan50
            // 
            this.RdoLessthan50.AutoSize = true;
            this.RdoLessthan50.Location = new System.Drawing.Point(115, 101);
            this.RdoLessthan50.Name = "RdoLessthan50";
            this.RdoLessthan50.Size = new System.Drawing.Size(86, 17);
            this.RdoLessthan50.TabIndex = 2;
            this.RdoLessthan50.TabStop = true;
            this.RdoLessthan50.Text = "Less than 50";
            this.RdoLessthan50.UseVisualStyleBackColor = true;
            // 
            // BtnGenerate2
            // 
            this.BtnGenerate2.Location = new System.Drawing.Point(157, 36);
            this.BtnGenerate2.Name = "BtnGenerate2";
            this.BtnGenerate2.Size = new System.Drawing.Size(75, 23);
            this.BtnGenerate2.TabIndex = 1;
            this.BtnGenerate2.Text = "Generate";
            this.BtnGenerate2.UseVisualStyleBackColor = true;
            // 
            // cmbRandom2
            // 
            this.cmbRandom2.FormattingEnabled = true;
            this.cmbRandom2.Location = new System.Drawing.Point(6, 36);
            this.cmbRandom2.Name = "cmbRandom2";
            this.cmbRandom2.Size = new System.Drawing.Size(121, 21);
            this.cmbRandom2.TabIndex = 0;
            // 
            // LblCount
            // 
            this.LblCount.AutoSize = true;
            this.LblCount.Location = new System.Drawing.Point(7, 85);
            this.LblCount.Name = "LblCount";
            this.LblCount.Size = new System.Drawing.Size(40, 13);
            this.LblCount.TabIndex = 5;
            this.LblCount.Text = "Count:";
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(509, 252);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 6;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            // 
            // FrmRandomCom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 287);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRandomCom";
            this.Text = "RandomCom";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRandom1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnReset1;
        private System.Windows.Forms.RadioButton RdoGreaterthan500;
        private System.Windows.Forms.RadioButton RdoLessthan500;
        private System.Windows.Forms.Button BtnGenerate1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LblCount;
        private System.Windows.Forms.Button BtnReset2;
        private System.Windows.Forms.RadioButton RdoRdoGreaterthan50;
        private System.Windows.Forms.RadioButton RdoLessthan50;
        private System.Windows.Forms.Button BtnGenerate2;
        private System.Windows.Forms.ComboBox cmbRandom2;
        private System.Windows.Forms.Button BtnBack;
    }
}