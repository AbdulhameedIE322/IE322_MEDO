
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IE322_MEDO
{
    public partial class frmMain : Form
    {
        string username = "meed";
        string password = "hello";
        int attempt = 1;
        int MaxAttempts = 3;
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
         
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if (MaxAttempts == 0)
            {
                Close();
            }
            else
            {
                while (attempt <= MaxAttempts)
                {
                    if (Txt_Username.Text != username)
                    {
                        // username is incorrect
                        MessageBox.Show("Invalid username, " + (MaxAttempts - attempt) + " attempts remaining");
                        attempt++;
                        Txt_Username.Clear();
                        Txt_Password.Clear();
                        return;
                    }
                    else
                    {   // username is correct
                        // so check password			
                        if (Txt_Password.Text != password)
                        {
                            // Incorrect password
                            attempt++;
                            MessageBox.Show("Incorrect password," + (MaxAttempts - attempt) + " attempts remaining");
                            Txt_Username.Clear();
                            Txt_Password.Clear();
                            return;
                        }
                        else
                        {
                            //Both are correct
                            attempt = 0; // reset the number of attempts
                            MessageBox.Show("Login successful");



                            Btn_Login.Text = "Logout";
                            Txt_Username.Clear();
                            Txt_Password.Clear();
                            // this.Width = 1600;
                            break; // come out of while loop
                        }//endif

                    }//endif

                }//end while
            }
        }

        private void Btn_About_Click(object sender, EventArgs e)
        {
            Btn_About.Enabled=false;
        }

        private void Btn_radio_Click(object sender, EventArgs e)
        {
            FrmRadio frm = new FrmRadio();
            frm.ShowDialog();
        }

        private void Btn_CheckBox_Click(object sender, EventArgs e)
        {
            FrmCheckbox frm = new FrmCheckbox();
            frm.ShowDialog();
        }

        private void Btn_Combo_Click(object sender, EventArgs e)
        {
            FrmCombo frm = new FrmCombo();
            frm.ShowDialog();
        }

        private void Btn_Random_Click(object sender, EventArgs e)
        {
             FrmRandom frm = new FrmRandom();
             frm.ShowDialog();
        }

        private void Btn_RandomCom_Click(object sender, EventArgs e)
        {
            FrmRandomCom frm = new FrmRandomCom();
            frm.ShowDialog();
        }

        private void Btn_PictureBox_Click(object sender, EventArgs e)
        {
            FrmPictureBox1 frm = new FrmPictureBox1();
            frm.ShowDialog();
        }

        private void BtnArray_Click(object sender, EventArgs e)
        {
            frmArray frm = new frmArray();
            frm.ShowDialog();
        }

        private void Txt_Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
