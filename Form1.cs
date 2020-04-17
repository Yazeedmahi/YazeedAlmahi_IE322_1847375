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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            int num = 1;
            int numm = 0;
            string username = "yazeed";
            string password = "meme1";

            while (num < 4)
            {

                if (Txtuser.Text == username && TxtPw.Text == password)
                {
                    MessageBox.Show("YOU IN HOMIE");
                    break;

                }

                else if (Txtuser.Text == "" && TxtPw.Text == "")
                {
                    MessageBox.Show("write something");
                    num += 3;

                }
                else if (Txtuser.Text != "username")
                {
                    MessageBox.Show("Wrong Username Homie" + "attempts made" + (4 - num));
                    num++;

                }

                
                else
                {
                    MessageBox.Show("WRONG LOG ININFO HOMIE" + "attempts made " + (4 - num));
                    num++;
                    numm++;

                }







            }

            // private void button17_Click(object sender, EventArgs e)
            {

            }

            //private void button3_Click(object sender, EventArgs e)
            {

            }

            //private void BtnABCAnalysis_Click(object sender, EventArgs e)
            {

            }
        }

        private void BtnRadio_Click(object sender, EventArgs e)
        {
            FrmRadiocs frm = new FrmRadiocs();
            frm.ShowDialog();
        }

        private void BtnCheckbox_Click(object sender, EventArgs e)
        {
            FrmCheck frm = new FrmCheck();
            frm.ShowDialog();
        }

        private void LblForgot_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Your Password is reset " +
                " username: admin" +
                "password: admin");

            
        }

        private void BtnCombo_Click(object sender, EventArgs e)
        {
            FrmCombo frm = new FrmCombo();
            frm.ShowDialog();
        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            FrmRandom frm = new FrmRandom();
            frm.ShowDialog();

        }

        private void BtnRandomCombo_Click(object sender, EventArgs e)
        {
            FrmRandomCombo frm = new FrmRandomCombo();
            frm.ShowDialog();
        }

        private void PicterBox1_Click(object sender, EventArgs e)
        {
            FrmPicterBox frm = new FrmPicterBox();
            frm.ShowDialog();
        }

        private void BtnCalculator_Click(object sender, EventArgs e)
        {
            FrmCalculator frm = new FrmCalculator();
            frm.ShowDialog();
        }

        private void BtnAtm_Click(object sender, EventArgs e)
        {
            FrmAtm frm = new FrmAtm();
            frm.ShowDialog();
        }

        private void BtnCarApp_Click(object sender, EventArgs e)
        {
            CarApp frm = new CarApp();
            frm.ShowDialog();
        }

        private void BtnArray_Click(object sender, EventArgs e)
        {
             FrmmArraycs frm = new FrmmArraycs();
            frm.ShowDialog();
        }

        private void BtnPictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}