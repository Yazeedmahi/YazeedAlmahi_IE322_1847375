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
    public partial class FrmCalculator : Form
    {
        int N1;
        int N2;
        static int Add(int N1, int N2)
        {
            return N1 + N2;
        }
        static int Subtract(int N1, int N2)
        {
            return N1 - N2;
        }
        static int Multiply(int N1, int N2)
        {
            return N1 * N2;
        }

        static int Divide(int N1, int N2)
        {
            int e;
            e = N1 / N2;
            return e;
        }

        static int Rem(int N1, int N2)
        {
            return N1 % N2;
        }
        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Add(N1, N2);
            MessageBox.Show("The addition is" + Add(N1, N2));
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            Subtract(N1, N2);
            MessageBox.Show("The subrtaction of  is" + Subtract(N1, N2));
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            Multiply(N1, N2);
            MessageBox.Show("The Multiplication  is" + Multiply(N1, N2));
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            Divide(N1, N2);
            MessageBox.Show("The Division is" + Divide(N1, N2));
        }

        private void BtnRem_Click(object sender, EventArgs e)
        {
            Rem(N1, N2);
            MessageBox.Show("The remaider  is" + Rem(N1, N2));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            N1 = Convert.ToInt32(textBox1.Text);
            N2 = Convert.ToInt32(textBox2.Text);
        }
    }
}
