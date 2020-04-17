namespace IE322_MEDO
{
    partial class FrmCombo
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
            this.btnShowSelectedMethod1 = new System.Windows.Forms.Button();
            this.btnShowSelectedMethod2 = new System.Windows.Forms.Button();
            this.btnRemove2ndItem = new System.Windows.Forms.Button();
            this.btnRemoveLastItem = new System.Windows.Forms.Button();
            this.btnRemoveByIndex = new System.Windows.Forms.Button();
            this.btnRemoveByName = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.CmbDays = new System.Windows.Forms.ComboBox();
            this.TxtDays = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShowSelectedMethod1
            // 
            this.btnShowSelectedMethod1.Location = new System.Drawing.Point(12, 12);
            this.btnShowSelectedMethod1.Name = "btnShowSelectedMethod1";
            this.btnShowSelectedMethod1.Size = new System.Drawing.Size(101, 45);
            this.btnShowSelectedMethod1.TabIndex = 0;
            this.btnShowSelectedMethod1.Text = "Show Selected Method 1";
            this.btnShowSelectedMethod1.UseVisualStyleBackColor = true;
            this.btnShowSelectedMethod1.Click += new System.EventHandler(this.btnShowSelectedMethod1_Click);
            // 
            // btnShowSelectedMethod2
            // 
            this.btnShowSelectedMethod2.Location = new System.Drawing.Point(119, 12);
            this.btnShowSelectedMethod2.Name = "btnShowSelectedMethod2";
            this.btnShowSelectedMethod2.Size = new System.Drawing.Size(101, 45);
            this.btnShowSelectedMethod2.TabIndex = 1;
            this.btnShowSelectedMethod2.Text = "Show Selected Method 2";
            this.btnShowSelectedMethod2.UseVisualStyleBackColor = true;
            this.btnShowSelectedMethod2.Click += new System.EventHandler(this.btnShowSelectedMethod2_Click);
            // 
            // btnRemove2ndItem
            // 
            this.btnRemove2ndItem.Location = new System.Drawing.Point(308, 148);
            this.btnRemove2ndItem.Name = "btnRemove2ndItem";
            this.btnRemove2ndItem.Size = new System.Drawing.Size(83, 78);
            this.btnRemove2ndItem.TabIndex = 2;
            this.btnRemove2ndItem.Text = "Remove 2nd Item";
            this.btnRemove2ndItem.UseVisualStyleBackColor = true;
            this.btnRemove2ndItem.Click += new System.EventHandler(this.btnRemove2ndItem_Click);
            // 
            // btnRemoveLastItem
            // 
            this.btnRemoveLastItem.Location = new System.Drawing.Point(308, 31);
            this.btnRemoveLastItem.Name = "btnRemoveLastItem";
            this.btnRemoveLastItem.Size = new System.Drawing.Size(83, 78);
            this.btnRemoveLastItem.TabIndex = 3;
            this.btnRemoveLastItem.Text = "Remove Last Item";
            this.btnRemoveLastItem.UseVisualStyleBackColor = true;
            this.btnRemoveLastItem.Click += new System.EventHandler(this.btnRemoveLastItem_Click);
            // 
            // btnRemoveByIndex
            // 
            this.btnRemoveByIndex.Location = new System.Drawing.Point(12, 235);
            this.btnRemoveByIndex.Name = "btnRemoveByIndex";
            this.btnRemoveByIndex.Size = new System.Drawing.Size(85, 44);
            this.btnRemoveByIndex.TabIndex = 4;
            this.btnRemoveByIndex.Text = "Remove By Index";
            this.btnRemoveByIndex.UseVisualStyleBackColor = true;
            this.btnRemoveByIndex.Click += new System.EventHandler(this.btnRemoveByIndex_Click);
            // 
            // btnRemoveByName
            // 
            this.btnRemoveByName.Location = new System.Drawing.Point(150, 235);
            this.btnRemoveByName.Name = "btnRemoveByName";
            this.btnRemoveByName.Size = new System.Drawing.Size(85, 44);
            this.btnRemoveByName.TabIndex = 5;
            this.btnRemoveByName.Text = "Remove By Name";
            this.btnRemoveByName.UseVisualStyleBackColor = true;
            this.btnRemoveByName.Click += new System.EventHandler(this.btnRemoveByName_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(316, 286);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CmbDays
            // 
            this.CmbDays.FormattingEnabled = true;
            this.CmbDays.Location = new System.Drawing.Point(99, 119);
            this.CmbDays.Name = "CmbDays";
            this.CmbDays.Size = new System.Drawing.Size(121, 21);
            this.CmbDays.TabIndex = 7;
            this.CmbDays.SelectedIndexChanged += new System.EventHandler(this.CmbDays_SelectedIndexChanged);
            // 
            // TxtDays
            // 
            this.TxtDays.AutoSize = true;
            this.TxtDays.Location = new System.Drawing.Point(20, 119);
            this.TxtDays.Name = "TxtDays";
            this.TxtDays.Size = new System.Drawing.Size(31, 13);
            this.TxtDays.TabIndex = 8;
            this.TxtDays.Text = "Days";
            // 
            // FrmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 321);
            this.Controls.Add(this.TxtDays);
            this.Controls.Add(this.CmbDays);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRemoveByName);
            this.Controls.Add(this.btnRemoveByIndex);
            this.Controls.Add(this.btnRemoveLastItem);
            this.Controls.Add(this.btnRemove2ndItem);
            this.Controls.Add(this.btnShowSelectedMethod2);
            this.Controls.Add(this.btnShowSelectedMethod1);
            this.Name = "FrmCombo";
            this.Text = "Combo";
            this.Load += new System.EventHandler(this.FrmCombo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowSelectedMethod1;
        private System.Windows.Forms.Button btnShowSelectedMethod2;
        private System.Windows.Forms.Button btnRemove2ndItem;
        private System.Windows.Forms.Button btnRemoveLastItem;
        private System.Windows.Forms.Button btnRemoveByIndex;
        private System.Windows.Forms.Button btnRemoveByName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox CmbDays;
        private System.Windows.Forms.Label TxtDays;
    }
}