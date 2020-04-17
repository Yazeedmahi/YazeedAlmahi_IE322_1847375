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
    public partial class FrmAtm : Form
    {
        int b=500;
        int a;
        int c;
        Atmcs Person1 = new Atmcs();
        int Desposit(int a)
        {

            b = b + a;
            return b;


        }

        int Withdraw(int c)
        {

            b = b - c;
            return b;

        }

        int Checkbalance(int b)
        {


            return b;


        }


        public FrmAtm()
        {
            InitializeComponent();
        }

        private void BtnDeposit_Click(object sender, EventArgs e)
        {
           Desposit(a);
            MessageBox.Show("+5 form balance" + "current balance is" + b);

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnWithdraw_Click(object sender, EventArgs e)
        {
            Withdraw(c);
            MessageBox.Show("-5 form balance"+ "current balance is" + b);
        }

        private void BtnCheckBalance_Click(object sender, EventArgs e)
        {
            Checkbalance(b);
            MessageBox.Show("current balance is" + b);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox3.Text);
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            c = Convert.ToInt32(textBox2.Text);
        }
    }
}
