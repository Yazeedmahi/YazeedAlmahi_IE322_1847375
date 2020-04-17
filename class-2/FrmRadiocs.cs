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
    public partial class FrmRadiocs : Form
    {
        public FrmRadiocs()
        {
            InitializeComponent();
           
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void FrmRadiocs_Load(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)//
        {
            if (RdoBlue2.Checked == true)
                RdoBlue2.ForeColor = Color.FromArgb(0, 0, 255);
            else
                RdoBlue2.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void RdoRed_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoRed.Checked == true)
                RdoRed.ForeColor = Color.FromArgb(255, 0, 0);
            else
                RdoRed.ForeColor = Color.FromArgb(0, 0, 0);

        }

        private void RdoGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoGreen.Checked == true)
                RdoGreen.ForeColor = Color.FromArgb(0, 255 , 0);
            else
                RdoGreen.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void RdoBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoBlue.Checked == true)
                RdoBlue.ForeColor = Color.FromArgb(0, 0, 255);
            else
                RdoBlue.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void RdoYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoYellow.Checked == true)
                RdoYellow.ForeColor = Color.FromArgb(50, 200 , 50);
            else
                RdoYellow.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void RdoYellow2_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoYellow2.Checked == true)
                RdoYellow2.ForeColor = Color.FromArgb(50, 200, 50);
            else
                RdoYellow2.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            RdoYellow.Checked = false;
            RdoBlue.Checked = false;
            RdoRed.Checked = false;
            RdoGreen.Checked = false;
            RdoYellow2.Checked = false;
            RdoBlue2.Checked = false;
            RdoRed2.Checked = false;
            RdoGreen2.Checked = false;
            MessageBox.Show("radio buttons have been reseted");
        }

        private void RdoRed2_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoRed2.Checked == true)
                RdoRed2.ForeColor = Color.FromArgb(255, 0, 0);
            else
                RdoRed2.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void RdoGreen2_CheckedChanged(object sender, EventArgs e)
        {

            if (RdoGreen2.Checked == true)
                RdoGreen2.ForeColor = Color.FromArgb(0, 255, 0);
            else
                RdoGreen2.ForeColor = Color.FromArgb(0, 0, 0);
        }
    }
}
