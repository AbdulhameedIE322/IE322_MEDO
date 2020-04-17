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
    public partial class FrmRandomCom : Form
    {
        public FrmRandomCom()
        {
            InitializeComponent();
        }

        private void BtnGenerate1_Click(object sender, EventArgs e)
        {
            cmbRandom1.ResetText();
            cmbRandom1.Items.Clear();
            Random r = new Random();
            for (int i =0; i<r.Next(1,50)-1; i++)
            {
                cmbRandom1.Items.Add(r.Next(100, 999));
            }
        }
    }
}
