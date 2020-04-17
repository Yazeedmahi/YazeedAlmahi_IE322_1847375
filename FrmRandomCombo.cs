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
    public partial class FrmRandomCombo : Form
       
    {
        Random M = new Random();
        public FrmRandomCombo()
        {
            InitializeComponent();
        }

        private void BtnGenrate_Click(object sender, EventArgs e)
        {
            int meme;
            int i;
            CmbRandom.ResetText();
            CmbRandom.Items.Clear();
          
            //meme = Convert.ToString(y.Next(1, 100));
            // MessageBox.Show(BtnGrandom.Text);
            //this.BtnTextBox.Text = BtnGrandom.Text.ToString();

            for (i = 0; i< M.Next(10,60)-1; i++) 
            {
                CmbRandom.Items.Add(M.Next(100, 999));
            }

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            CmbRandom.ResetText();
            CmbRandom.Items.Clear();

        }
    }
}
