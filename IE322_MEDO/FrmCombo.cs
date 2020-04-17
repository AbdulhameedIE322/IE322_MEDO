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
    public partial class FrmCombo : Form
    {
        public FrmCombo()
        {
            InitializeComponent();
            CmbDays.Items.Add("Sunday");
            CmbDays.Items.Add("Monday");
            CmbDays.Items.Add("Tuesday");
            CmbDays.Items.Add("Wednesday");
            CmbDays.Items.Add("Thursday");
            CmbDays.Items.Add("Friday");
            CmbDays.Items.Add("Saturday");
        }

        private void btnRemoveByName_Click(object sender, EventArgs e)
        {
            CmbDays.Items.Remove(CmbDays.Text);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void CmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmCombo_Load(object sender, EventArgs e)
        {

        }

        private void btnShowSelectedMethod1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CmbDays.Text);
        }

        private void btnRemoveByIndex_Click(object sender, EventArgs e)
        {
            CmbDays.Items.RemoveAt(1);
        }

        private void btnShowSelectedMethod2_Click(object sender, EventArgs e)
        {
            var item =
                this.CmbDays.GetItemText(this.CmbDays.SelectedItem);
            MessageBox.Show(item);
        }

        private void btnRemoveLastItem_Click(object sender, EventArgs e)
        {
            if (CmbDays.Items.Count >= 1)
            {
                CmbDays.Items.RemoveAt(CmbDays.Items.Count - 1);
            }
            else
            {
                MessageBox.Show("Can't Remove Last Item");
            }

        }

        private void btnRemove2ndItem_Click(object sender, EventArgs e)
        {
            if(CmbDays.Items.Count >= 2)
            {
                CmbDays.Items.RemoveAt(CmbDays.Items.Count - 2);
            }
            else
            {
                MessageBox.Show("Can't Remove 2nd Last Item");
            }
        }
    }
}
