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
    public partial class FrmRadio : Form
    {
        public FrmRadio()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void rdoRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoRed.Checked==true)
            {
                rdoRed.ForeColor = Color.FromArgb(255, 0, 0);
                // or  rdoRed.ForeColor = Color.FromName("red"); 
            }
            else
            {
                rdoRed.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void rdoGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoGreen.Checked == true)
            {
                rdoGreen.ForeColor = Color.FromArgb(0, 255, 0);
            }
            else
            {
                rdoGreen.ForeColor = Color.FromArgb(0, 0, 0);
            }

        }

        private void rdoBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBlue.Checked==true)
            {
                rdoBlue.ForeColor = Color.FromArgb(0, 0, 255); 
            }
            else
            {
                rdoBlue.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void rdoYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoYellow.Checked==true)
            {
                rdoYellow.ForeColor = Color.FromArgb(255, 255, 0); 
            }
            else
            {
                rdoYellow.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rdoRed.ForeColor = Color.FromArgb(0, 0, 0);
            rdoGreen.ForeColor = Color.FromArgb(0, 0, 0);
            rdoBlue.ForeColor = Color.FromArgb(0, 0, 0);
            rdoYellow.ForeColor = Color.FromArgb(0, 0, 0);
            rdoRed.Checked = false;
            rdoGreen.Checked = false;
            rdoBlue.Checked = false;
            rdoYellow.Checked = false;
            rdoRed2.ForeColor = Color.FromArgb(0, 0, 0);
            rdoGreen2.ForeColor = Color.FromArgb(0, 0, 0);
            rdoBlue2.ForeColor = Color.FromArgb(0, 0, 0);
            rdoYellow2.ForeColor = Color.FromArgb(0, 0, 0);
            rdoRed2.Checked = false;
            rdoGreen2.Checked = false;
            rdoBlue2.Checked = false;
            rdoYellow2.Checked = false;
        }

        private void rdoRed2_CheckedChanged(object sender, EventArgs e)
        {
            rdoRed2.ForeColor = Color.FromArgb(255, 0, 0);
        }

        private void rdoGreen2_CheckedChanged(object sender, EventArgs e)
        {
            rdoGreen2.ForeColor = Color.FromArgb(0, 255, 0);
        }

        private void rdoBlue2_CheckedChanged(object sender, EventArgs e)
        {
            rdoBlue2.ForeColor = Color.FromArgb(0, 0, 255);
        }

        private void rdoYellow2_CheckedChanged(object sender, EventArgs e)
        {
            rdoYellow2.ForeColor = Color.FromArgb(255, 255, 0);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmRadio_Load(object sender, EventArgs e)
        {

        }
    }
}
