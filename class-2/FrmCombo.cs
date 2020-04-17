using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_2
{
    public partial class FrmCombo : Form
    {
        public FrmCombo()
        {
            InitializeComponent();
            CmBDays.Items.Add("sunday");
            CmBDays.Items.Add("monday");
            CmBDays.Items.Add("tuseday");
            CmBDays.Items.Add("wendsday");
            CmBDays.Items.Add("thursday");
            CmBDays.Items.Add("friday");
            CmBDays.Items.Add("saturday");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CmBDays.Text);
        }

        private void FrmCombo_Load(object sender, EventArgs e)
        {

        }

        private void BtnM2_Click(object sender, EventArgs e)
        {
            var item = CmBDays.GetItemText(CmBDays.SelectedItem);
            MessageBox.Show(CmBDays.Text);

          
        }

        private void BtnName_Click(object sender, EventArgs e)
        {
            CmBDays.Items.Remove(CmBDays.SelectedItem);
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            CmBDays.Items.RemoveAt(0);
        }

        private void BtnLastItem_Click(object sender, EventArgs e)
        {
            int counter = CmBDays.Items.Count;

            CmBDays.Items.RemoveAt(counter-1);





        }

        private void Btn2ndLastItem_Click(object sender, EventArgs e)
        {
            int counter = CmBDays.Items.Count;

            CmBDays.Items.RemoveAt(counter - 2);

        }
    }
}
