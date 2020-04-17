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
    public partial class FrmPictureBox1 : Form
    {
        public FrmPictureBox1()
        {
            InitializeComponent();
        }

        private void BtnLoadimage_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\IE322_1845539\\IE322.png");
        }
    }
}
