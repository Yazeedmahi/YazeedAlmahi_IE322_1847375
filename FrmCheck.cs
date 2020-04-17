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
    public partial class FrmCheck : Form
    {
        public FrmCheck()
        {
            InitializeComponent();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (ChkCofee.Checked == true)
            {
                msg = ChkCofee.Text;
            }

            if (ChkDonut.Checked == true)
            {
                msg = msg + ChkDonut.Text;
            }

            if (ChkBrownie.Checked == true)
            {
                msg = msg + ChkBrownie.Text;
            }

            if ((msg.Length>0))
            {
                MessageBox.Show(msg +"--"+ " is orded");
            }
            else
            {
                MessageBox.Show("Please select something homie");

            }
            

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        //private void FrmCheck_Load(object sender, EventArgs e)
        //{

    }
    }
//}
