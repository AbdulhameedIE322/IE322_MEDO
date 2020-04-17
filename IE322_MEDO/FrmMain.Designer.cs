namespace IE322_MEDO
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Txt_Username = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Txt_PW = new System.Windows.Forms.Label();
            this.Txt_User = new System.Windows.Forms.Label();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnArray = new System.Windows.Forms.Button();
            this.Btn_Combo = new System.Windows.Forms.Button();
            this.Btn_CheckBox = new System.Windows.Forms.Button();
            this.Btn_radio = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Btn_GroupieApp = new System.Windows.Forms.Button();
            this.Btn_SelfieApp = new System.Windows.Forms.Button();
            this.Btn_PictureBox2 = new System.Windows.Forms.Button();
            this.Btn_PictureBox = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Btn_RandomCom = new System.Windows.Forms.Button();
            this.Btn_Random = new System.Windows.Forms.Button();
            this.Btn_Timer = new System.Windows.Forms.Button();
            this.Btn_Progress = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Btn_Talk = new System.Windows.Forms.Button();
            this.Btn_Draw = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Btn_Johari = new System.Windows.Forms.Button();
            this.Btn_ABCAnalysis = new System.Windows.Forms.Button();
            this.Btn_RoboticCells = new System.Windows.Forms.Button();
            this.Btn_ManufacturingCell = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.Btn_Arduino = new System.Windows.Forms.Button();
            this.Btn_About = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Login
            // 
            this.Btn_Login.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_Login.Font = new System.Drawing.Font("Tahoma", 15F);
            this.Btn_Login.Location = new System.Drawing.Point(201, 125);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(114, 43);
            this.Btn_Login.TabIndex = 0;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.UseVisualStyleBackColor = false;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Txt_Username
            // 
            this.Txt_Username.Location = new System.Drawing.Point(126, 36);
            this.Txt_Username.Name = "Txt_Username";
            this.Txt_Username.Size = new System.Drawing.Size(189, 20);
            this.Txt_Username.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Txt_Password);
            this.groupBox1.Controls.Add(this.Txt_PW);
            this.groupBox1.Controls.Add(this.Txt_User);
            this.groupBox1.Controls.Add(this.Txt_Username);
            this.groupBox1.Controls.Add(this.Btn_Login);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(221, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 174);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login to IE322";
            // 
            // Txt_Password
            // 
            this.Txt_Password.Location = new System.Drawing.Point(126, 84);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(189, 20);
            this.Txt_Password.TabIndex = 5;
            this.Txt_Password.TextChanged += new System.EventHandler(this.Txt_Password_TextChanged);
            // 
            // Txt_PW
            // 
            this.Txt_PW.AutoSize = true;
            this.Txt_PW.Location = new System.Drawing.Point(37, 84);
            this.Txt_PW.Name = "Txt_PW";
            this.Txt_PW.Size = new System.Drawing.Size(53, 13);
            this.Txt_PW.TabIndex = 4;
            this.Txt_PW.Text = "Password";
            this.Txt_PW.Click += new System.EventHandler(this.label2_Click);
            // 
            // Txt_User
            // 
            this.Txt_User.AccessibleName = "";
            this.Txt_User.AutoSize = true;
            this.Txt_User.Location = new System.Drawing.Point(37, 36);
            this.Txt_User.Name = "Txt_User";
            this.Txt_User.Size = new System.Drawing.Size(55, 13);
            this.Txt_User.TabIndex = 3;
            this.Txt_User.Text = "Username";
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.Color.Red;
            this.Btn_Exit.Font = new System.Drawing.Font("Tahoma", 25F);
            this.Btn_Exit.Location = new System.Drawing.Point(12, 445);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(813, 68);
            this.Btn_Exit.TabIndex = 2;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.BtnArray);
            this.groupBox2.Controls.Add(this.Btn_Combo);
            this.groupBox2.Controls.Add(this.Btn_CheckBox);
            this.groupBox2.Controls.Add(this.Btn_radio);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(655, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 201);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basic Controls";
            // 
            // BtnArray
            // 
            this.BtnArray.ForeColor = System.Drawing.Color.Black;
            this.BtnArray.Location = new System.Drawing.Point(7, 146);
            this.BtnArray.Name = "BtnArray";
            this.BtnArray.Size = new System.Drawing.Size(130, 34);
            this.BtnArray.TabIndex = 3;
            this.BtnArray.Text = "Array";
            this.BtnArray.UseVisualStyleBackColor = true;
            this.BtnArray.Click += new System.EventHandler(this.BtnArray_Click);
            // 
            // Btn_Combo
            // 
            this.Btn_Combo.ForeColor = System.Drawing.Color.Black;
            this.Btn_Combo.Location = new System.Drawing.Point(6, 108);
            this.Btn_Combo.Name = "Btn_Combo";
            this.Btn_Combo.Size = new System.Drawing.Size(144, 29);
            this.Btn_Combo.TabIndex = 2;
            this.Btn_Combo.Text = "Combo";
            this.Btn_Combo.UseVisualStyleBackColor = true;
            this.Btn_Combo.Click += new System.EventHandler(this.Btn_Combo_Click);
            // 
            // Btn_CheckBox
            // 
            this.Btn_CheckBox.ForeColor = System.Drawing.Color.Black;
            this.Btn_CheckBox.Location = new System.Drawing.Point(6, 73);
            this.Btn_CheckBox.Name = "Btn_CheckBox";
            this.Btn_CheckBox.Size = new System.Drawing.Size(144, 29);
            this.Btn_CheckBox.TabIndex = 1;
            this.Btn_CheckBox.Text = "CheckBox";
            this.Btn_CheckBox.UseVisualStyleBackColor = true;
            this.Btn_CheckBox.Click += new System.EventHandler(this.Btn_CheckBox_Click);
            // 
            // Btn_radio
            // 
            this.Btn_radio.ForeColor = System.Drawing.Color.Black;
            this.Btn_radio.Location = new System.Drawing.Point(6, 38);
            this.Btn_radio.Name = "Btn_radio";
            this.Btn_radio.Size = new System.Drawing.Size(144, 29);
            this.Btn_radio.TabIndex = 0;
            this.Btn_radio.Text = "Radio";
            this.Btn_radio.UseVisualStyleBackColor = true;
            this.Btn_radio.Click += new System.EventHandler(this.Btn_radio_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.Btn_GroupieApp);
            this.groupBox3.Controls.Add(this.Btn_SelfieApp);
            this.groupBox3.Controls.Add(this.Btn_PictureBox2);
            this.groupBox3.Controls.Add(this.Btn_PictureBox);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(261, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(176, 201);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Graphical";
            // 
            // Btn_GroupieApp
            // 
            this.Btn_GroupieApp.ForeColor = System.Drawing.Color.Black;
            this.Btn_GroupieApp.Location = new System.Drawing.Point(17, 146);
            this.Btn_GroupieApp.Name = "Btn_GroupieApp";
            this.Btn_GroupieApp.Size = new System.Drawing.Size(144, 34);
            this.Btn_GroupieApp.TabIndex = 3;
            this.Btn_GroupieApp.Text = "Groupie App";
            this.Btn_GroupieApp.UseVisualStyleBackColor = true;
            // 
            // Btn_SelfieApp
            // 
            this.Btn_SelfieApp.ForeColor = System.Drawing.Color.Black;
            this.Btn_SelfieApp.Location = new System.Drawing.Point(17, 106);
            this.Btn_SelfieApp.Name = "Btn_SelfieApp";
            this.Btn_SelfieApp.Size = new System.Drawing.Size(144, 34);
            this.Btn_SelfieApp.TabIndex = 2;
            this.Btn_SelfieApp.Text = "SelfieApp";
            this.Btn_SelfieApp.UseVisualStyleBackColor = true;
            // 
            // Btn_PictureBox2
            // 
            this.Btn_PictureBox2.ForeColor = System.Drawing.Color.Black;
            this.Btn_PictureBox2.Location = new System.Drawing.Point(17, 71);
            this.Btn_PictureBox2.Name = "Btn_PictureBox2";
            this.Btn_PictureBox2.Size = new System.Drawing.Size(144, 29);
            this.Btn_PictureBox2.TabIndex = 1;
            this.Btn_PictureBox2.Text = "PictureBox2";
            this.Btn_PictureBox2.UseVisualStyleBackColor = true;
            // 
            // Btn_PictureBox
            // 
            this.Btn_PictureBox.ForeColor = System.Drawing.Color.Black;
            this.Btn_PictureBox.Location = new System.Drawing.Point(17, 36);
            this.Btn_PictureBox.Name = "Btn_PictureBox";
            this.Btn_PictureBox.Size = new System.Drawing.Size(144, 29);
            this.Btn_PictureBox.TabIndex = 0;
            this.Btn_PictureBox.Text = "PictureBox";
            this.Btn_PictureBox.UseVisualStyleBackColor = true;
            this.Btn_PictureBox.Click += new System.EventHandler(this.Btn_PictureBox_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.Btn_RandomCom);
            this.groupBox4.Controls.Add(this.Btn_Random);
            this.groupBox4.Controls.Add(this.Btn_Timer);
            this.groupBox4.Controls.Add(this.Btn_Progress);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(454, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(184, 200);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "More Controls";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // Btn_RandomCom
            // 
            this.Btn_RandomCom.ForeColor = System.Drawing.Color.Black;
            this.Btn_RandomCom.Location = new System.Drawing.Point(20, 140);
            this.Btn_RandomCom.Name = "Btn_RandomCom";
            this.Btn_RandomCom.Size = new System.Drawing.Size(144, 29);
            this.Btn_RandomCom.TabIndex = 3;
            this.Btn_RandomCom.Text = "RandomCom";
            this.Btn_RandomCom.UseVisualStyleBackColor = true;
            this.Btn_RandomCom.Click += new System.EventHandler(this.Btn_RandomCom_Click);
            // 
            // Btn_Random
            // 
            this.Btn_Random.ForeColor = System.Drawing.Color.Black;
            this.Btn_Random.Location = new System.Drawing.Point(20, 105);
            this.Btn_Random.Name = "Btn_Random";
            this.Btn_Random.Size = new System.Drawing.Size(144, 29);
            this.Btn_Random.TabIndex = 2;
            this.Btn_Random.Text = "Random";
            this.Btn_Random.UseVisualStyleBackColor = true;
            this.Btn_Random.Click += new System.EventHandler(this.Btn_Random_Click);
            // 
            // Btn_Timer
            // 
            this.Btn_Timer.ForeColor = System.Drawing.Color.Black;
            this.Btn_Timer.Location = new System.Drawing.Point(20, 70);
            this.Btn_Timer.Name = "Btn_Timer";
            this.Btn_Timer.Size = new System.Drawing.Size(144, 29);
            this.Btn_Timer.TabIndex = 1;
            this.Btn_Timer.Text = "Timer";
            this.Btn_Timer.UseVisualStyleBackColor = true;
            // 
            // Btn_Progress
            // 
            this.Btn_Progress.ForeColor = System.Drawing.Color.Black;
            this.Btn_Progress.Location = new System.Drawing.Point(20, 35);
            this.Btn_Progress.Name = "Btn_Progress";
            this.Btn_Progress.Size = new System.Drawing.Size(144, 29);
            this.Btn_Progress.TabIndex = 0;
            this.Btn_Progress.Text = "Progress";
            this.Btn_Progress.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.Btn_Talk);
            this.groupBox5.Controls.Add(this.Btn_Draw);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(12, 332);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(130, 107);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Draw and Talk";
            // 
            // Btn_Talk
            // 
            this.Btn_Talk.ForeColor = System.Drawing.Color.Black;
            this.Btn_Talk.Location = new System.Drawing.Point(19, 65);
            this.Btn_Talk.Name = "Btn_Talk";
            this.Btn_Talk.Size = new System.Drawing.Size(95, 36);
            this.Btn_Talk.TabIndex = 1;
            this.Btn_Talk.Text = "Talk";
            this.Btn_Talk.UseVisualStyleBackColor = true;
            // 
            // Btn_Draw
            // 
            this.Btn_Draw.ForeColor = System.Drawing.Color.Black;
            this.Btn_Draw.Location = new System.Drawing.Point(19, 23);
            this.Btn_Draw.Name = "Btn_Draw";
            this.Btn_Draw.Size = new System.Drawing.Size(95, 36);
            this.Btn_Draw.TabIndex = 0;
            this.Btn_Draw.Text = "Draw";
            this.Btn_Draw.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.Btn_Johari);
            this.groupBox6.Controls.Add(this.Btn_ABCAnalysis);
            this.groupBox6.Controls.Add(this.Btn_RoboticCells);
            this.groupBox6.Controls.Add(this.Btn_ManufacturingCell);
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(12, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(224, 201);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Exam Apps";
            // 
            // Btn_Johari
            // 
            this.Btn_Johari.ForeColor = System.Drawing.Color.Black;
            this.Btn_Johari.Location = new System.Drawing.Point(19, 153);
            this.Btn_Johari.Name = "Btn_Johari";
            this.Btn_Johari.Size = new System.Drawing.Size(181, 34);
            this.Btn_Johari.TabIndex = 3;
            this.Btn_Johari.Text = "Johari";
            this.Btn_Johari.UseVisualStyleBackColor = true;
            // 
            // Btn_ABCAnalysis
            // 
            this.Btn_ABCAnalysis.ForeColor = System.Drawing.Color.Black;
            this.Btn_ABCAnalysis.Location = new System.Drawing.Point(19, 113);
            this.Btn_ABCAnalysis.Name = "Btn_ABCAnalysis";
            this.Btn_ABCAnalysis.Size = new System.Drawing.Size(181, 34);
            this.Btn_ABCAnalysis.TabIndex = 2;
            this.Btn_ABCAnalysis.Text = "ABC Analysis";
            this.Btn_ABCAnalysis.UseVisualStyleBackColor = true;
            // 
            // Btn_RoboticCells
            // 
            this.Btn_RoboticCells.ForeColor = System.Drawing.Color.Black;
            this.Btn_RoboticCells.Location = new System.Drawing.Point(19, 73);
            this.Btn_RoboticCells.Name = "Btn_RoboticCells";
            this.Btn_RoboticCells.Size = new System.Drawing.Size(181, 34);
            this.Btn_RoboticCells.TabIndex = 1;
            this.Btn_RoboticCells.Text = "Robotic Cells";
            this.Btn_RoboticCells.UseVisualStyleBackColor = true;
            // 
            // Btn_ManufacturingCell
            // 
            this.Btn_ManufacturingCell.ForeColor = System.Drawing.Color.Black;
            this.Btn_ManufacturingCell.Location = new System.Drawing.Point(19, 33);
            this.Btn_ManufacturingCell.Name = "Btn_ManufacturingCell";
            this.Btn_ManufacturingCell.Size = new System.Drawing.Size(181, 34);
            this.Btn_ManufacturingCell.TabIndex = 0;
            this.Btn_ManufacturingCell.Text = "Manufacturing Cell";
            this.Btn_ManufacturingCell.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Transparent;
            this.groupBox7.Controls.Add(this.Btn_Arduino);
            this.groupBox7.ForeColor = System.Drawing.Color.White;
            this.groupBox7.Location = new System.Drawing.Point(12, 233);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(130, 93);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Micro Controller";
            // 
            // Btn_Arduino
            // 
            this.Btn_Arduino.ForeColor = System.Drawing.Color.Black;
            this.Btn_Arduino.Location = new System.Drawing.Point(19, 22);
            this.Btn_Arduino.Name = "Btn_Arduino";
            this.Btn_Arduino.Size = new System.Drawing.Size(95, 46);
            this.Btn_Arduino.TabIndex = 0;
            this.Btn_Arduino.Text = "Arduino";
            this.Btn_Arduino.UseVisualStyleBackColor = true;
            // 
            // Btn_About
            // 
            this.Btn_About.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_About.Location = new System.Drawing.Point(750, 416);
            this.Btn_About.Name = "Btn_About";
            this.Btn_About.Size = new System.Drawing.Size(75, 23);
            this.Btn_About.TabIndex = 8;
            this.Btn_About.Text = "About";
            this.Btn_About.UseVisualStyleBackColor = false;
            this.Btn_About.Click += new System.EventHandler(this.Btn_About_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(837, 525);
            this.Controls.Add(this.Btn_About);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_Exit);
            this.Name = "frmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.TextBox Txt_Username;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Label Txt_PW;
        private System.Windows.Forms.Label Txt_User;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_Combo;
        private System.Windows.Forms.Button Btn_CheckBox;
        private System.Windows.Forms.Button Btn_radio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Btn_SelfieApp;
        private System.Windows.Forms.Button Btn_PictureBox2;
        private System.Windows.Forms.Button Btn_PictureBox;
        private System.Windows.Forms.Button Btn_GroupieApp;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Btn_RandomCom;
        private System.Windows.Forms.Button Btn_Random;
        private System.Windows.Forms.Button Btn_Timer;
        private System.Windows.Forms.Button Btn_Progress;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Btn_Talk;
        private System.Windows.Forms.Button Btn_Draw;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button Btn_Johari;
        private System.Windows.Forms.Button Btn_ABCAnalysis;
        private System.Windows.Forms.Button Btn_RoboticCells;
        private System.Windows.Forms.Button Btn_ManufacturingCell;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button Btn_Arduino;
        private System.Windows.Forms.Button Btn_About;
        private System.Windows.Forms.Button BtnArray;
    }
}

