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
    public partial class FrmCheckbox : Form
    {
        public FrmCheckbox()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string msg="";
            if (chkCoffee.Checked==true)
            {
                msg = msg + " " +chkCoffee.Text;
            }
            if (chkDonut.Checked == true)
            {
                msg = msg + " " + chkDonut.Text;
            }
            if (chkBrownei.Checked == true)
            {
                msg = msg + " " + chkBrownei.Text;
            }
              {
                if (msg.Length == 0)
                {
                    MessageBox.Show(" Nothing ordered ");
                }
                else
                    MessageBox.Show(msg + " ordered ");
                // Or just 
                //  if(msg.Length==0)
                //  {
                //      msg="Nothing Selected";
                //  }
                //     MessageBox.Show(msg);

            }


        }

        private void chkCoffee_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmCheckbox_Load(object sender, EventArgs e)
        {

        }
    }
}
