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
    public partial class FrmRandom : Form
    {
        Random y = new Random();

        public FrmRandom()
        {
            InitializeComponent();
        }

        private void FrmRandom_Load(object sender, EventArgs e)
        {

        }

        private void BtnNumber_Click(object sender, EventArgs e)
        {
           
            // MessageBox.Show(BtnGrandom.Text);
            this.BtnTextBox.Text = BtnGrandom.Text.ToString();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnGenrate_Click(object sender, EventArgs e)
        {
            BtnGrandom.Text = Convert.ToString(y.Next(1, 100));


        }

        private void BtnTextBox_TextChanged(object sender, EventArgs e)
        {
            BtnTextBox.Text = BtnGrandom.Text;

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
