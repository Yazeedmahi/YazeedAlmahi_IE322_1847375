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
    public partial class FrmmArraycs : Form
    {
        //1D Arrays


            Int32[] iArray3 = { 30, 56, 4, 44, 20 };//RECOMMENDED WAY:Declaration, Definition & Initialization
            Int32[] iArray4 = new Int32[] { 2, 1, 12, 5, 20 }; //Declaration, Definition & Initialization (can omit size value only if initialization)           
            Int32[] iArray5 = { 32, 40, 40, 40, 40 };//Declaration, Definition & Initialization (can omit new keyword only if initialization) 

            //2D Arrays
            int[,] iArray55 = new int[4, 4]; //Declaration and Definition of 2D array 
            int[,,] iArray345 = new int[3, 4, 5]; //Declaration and Definition of 3D array

            int[,] iArray32 = new int[3, 2]
                                    {
                                         { 2, 2 },
                                         { 3, 3 },
                                         { 1, 1 }
                                    }; //Declaration,Definition & Initialization of 2D array


            //Array to be filled with Random numbers
            Random r = new Random();
            int[] b = new int[100];
        


        void ModifyArray(Int32[] MyArray)
        {
            for (Int32 i = 0; i < MyArray.Length; i++)
            {
                MyArray[i] = MyArray[i] + 10;
            }
        }
        void ModifyElement(int AnElement)
        {
            AnElement = AnElement + 10;

            LabekDisplay1.Text = LabekDisplay1.Text + "\n\n" + "Value of Element from inside the called method is: " + AnElement;

        }
        public FrmmArraycs()
        {
            InitializeComponent();
        }

        private void BtnDisplay1DForLoop_Click(object sender, EventArgs e)
        {
            LabekDisplay1.Text = " Array using for Loop";
            for (Int32 i = 0; i < 5; i++)
            {
                LabekDisplay1.Text = LabekDisplay1.Text + "\n" + Convert.ToString(iArray3[i]);
                LabekDisplay1.ForeColor = System.Drawing.Color.DarkBlue;
            }
        }

        private void BtnDisplay1DForEachLoop_Click(object sender, EventArgs e)
        {
            LabekDisplay1.Text = " iArray1D with foreach Loop";

            foreach (Int32 j in iArray5)
            {
                LabekDisplay1.Text = LabekDisplay1.Text + "\n" + Convert.ToString(j);
                LabekDisplay1.ForeColor = System.Drawing.Color.DarkBlue;
            }
        }

        private void BtnDispArray_Click(object sender, EventArgs e)
        {
            LabekDisplay1.Text = "Some Methods and Properties of Random Array b :";
            ListR.Items.Clear();
            for (int i = 0; i < b.Length; i++)
            {

                b[i] = r.Next(1, 1000);
                ListR.Items.Add(b[i]);
            }

            LabekDisplay1.Text = LabekDisplay1.Text + "\n" + "Min of Random Array b is:" + b.Min();
            LabekDisplay1.Text = LabekDisplay1.Text + "\n" + "Max of Random Array  b is:" + b.Max();
            LabekDisplay1.Text = LabekDisplay1.Text + "\n" + "Sum of Random Array  b is:" + b.Sum();
            LabekDisplay1.Text = LabekDisplay1.Text + "\n" + "Average of Random Array b is:" + b.Average();
            LabekDisplay1.ForeColor = System.Drawing.Color.DarkBlue;
        }

        private void BtnDisplay2DForEachLoop_Click(object sender, EventArgs e)
        {
            LabekDisplay1.Text = " Array2D using nested for Loop";
            LabekDisplay1.ForeColor = System.Drawing.Color.DarkBlue;
            for (int i = 1; i < 4; i++)
            {
                LabekDisplay1.Text = LabekDisplay1.Text + "\n";
                LabekDisplay1.ForeColor = System.Drawing.Color.DarkBlue;

                for (int j = 1; j < 3; j++)
                {
                    LabekDisplay1.Text = LabekDisplay1.Text + "    " + Convert.ToString(iArray32[i - 1, j - 1]);
                    LabekDisplay1.ForeColor = System.Drawing.Color.DarkBlue;

                }
            }
        }

        private void BtnDisp2DArray_Click(object sender, EventArgs e)
        {
            LabekDisplay1.Text = "Some Methods and Properties:";
            LabekDisplay1.ForeColor = System.Drawing.Color.DarkBlue;

            // Some methods of Array
            LabekDisplay1.Text = LabekDisplay1.Text + "\n" + "Min of iArray5 is:" + iArray5.Min();
            LabekDisplay1.Text = LabekDisplay1.Text + "\n" + "Max of iArray5 is:" + iArray5.Max();
            LabekDisplay1.Text = LabekDisplay1.Text + "\n" + "Sum of iArray5 is:" + iArray5.Sum();
            LabekDisplay1.ForeColor = System.Drawing.Color.DarkBlue;

            // Some properties of Array
            LabekDisplay1.Text = LabekDisplay1.Text + "\n" + "Rank of iArray5 is:" + iArray5.Rank;   // Dimensions
            LabekDisplay1.Text = LabekDisplay1.Text + "\n" + "Length of iArray5 is:" + iArray5.Length;// size           
            LabekDisplay1.ForeColor = System.Drawing.Color.DarkBlue;

            LabekDisplay1.Text = LabekDisplay1.Text + "\n" + "Rank of iArray23 is:" + iArray32.Rank;   // Dimensions
            LabekDisplay1.Text = LabekDisplay1.Text + "\n" + "Length of iArray23 is:" + iArray32.Length;// Length: Total number of elements in all dimensions
            LabekDisplay1.ForeColor = System.Drawing.Color.DarkBlue;

            LabekDisplay1.Text = LabekDisplay1.Text + "\n" + "Number of Rows of  of iArray23 is:" + iArray32.GetLength(0);// first dimension
            LabekDisplay1.Text = LabekDisplay1.Text + "\n" + "Number of Columns of iArray23 is:" + iArray32.GetLength(1);//second dimension
            LabekDisplay1.ForeColor = System.Drawing.Color.DarkBlue;



        }

        private void BtnModifyAnArray_Click(object sender, EventArgs e)
        {

            LabekDisplay1.Text = "1D Array has \n following values before modyfiying";
            LabekDisplay1.ForeColor = System.Drawing.Color.DarkBlue;
            for (Int32 i = 0; i < 5; i++)
            {
                LabekDisplay1.Text = LabekDisplay1.Text + "\n" + Convert.ToString(iArray3[i]);
                LabekDisplay1.ForeColor = System.Drawing.Color.DarkBlue;
            }

            ModifyArray(iArray3);

            LabekDisplay1.Text = LabekDisplay1.Text + "\n\n" + "1D Array named iArray3 has \n following values AFTER MODIFICATION";
            LabekDisplay1.ForeColor = System.Drawing.Color.DarkBlue;
            for (Int32 i = 0; i < 5; i++)
            {
                LabekDisplay1.Text = LabekDisplay1.Text + "\n" + Convert.ToString(iArray3[i]);
                LabekDisplay1.ForeColor = System.Drawing.Color.DarkBlue;

            }
        }

        private void BtnModifyAnElement_Click(object sender, EventArgs e)
        {
            LabekDisplay1.Text = "1D Array named iArray3 has \n following values BEFORE MODIFICATION of ELEMENT#3";
            for (Int32 i = 0; i < 5; i++)
            {
                LabekDisplay1.Text = LabekDisplay1.Text + "\n" + Convert.ToString(iArray3[i]);
                LabekDisplay1.ForeColor = System.Drawing.Color.DarkBlue;

            }

            ModifyElement(iArray3[2]);

            LabekDisplay1.Text = LabekDisplay1.Text + "\n\n" + "1D Array named iArray3 has \n following values AFTER MODIFICATION of ELEMENT#3";
            LabekDisplay1.ForeColor = System.Drawing.Color.DarkBlue;
            for (Int32 i = 0; i < 5; i++)
            {
                LabekDisplay1.Text = LabekDisplay1.Text + "\n" + Convert.ToString(iArray3[i]);
                LabekDisplay1.ForeColor = System.Drawing.Color.DarkBlue;

            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ListR.Items.Clear();
            LabekDisplay1.Text = "";


            //1D Arrays


            Int32[] iArray3 = { 30, 56, 4, 44, 20 };//RECOMMENDED WAY:Declaration, Definition & Initialization
            Int32[] iArray4 = new Int32[] { 2, 1, 12, 5, 20 }; //Declaration, Definition & Initialization (can omit size value only if initialization)           
            Int32[] iArray5 = { 32, 40, 40, 40, 40 };//Declaration, Definition & Initialization (can omit new keyword only if initialization) 

            //2D Arrays
            int[,] iArray55 = new int[4, 4]; //Declaration and Definition of 2D array 
            int[,,] iArray345 = new int[3, 4, 5]; //Declaration and Definition of 3D array

            int[,] iArray32 = new int[3, 2]
                                    {
                                         { 2, 2 },
                                         { 3, 3 },
                                         { 1, 1 }
                                    }; //Declaration,Definition & Initialization of 2D array


            //Array to be filled with Random numbers
            Random r = new Random();
            int[] b = new int[100];


        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void LabelDisp_Click(object sender, EventArgs e)
        {
            LabekDisplay1.ForeColor = System.Drawing.Color.DarkBlue;
        }

        

        private void RichTextBoxDisp_Click(object sender, EventArgs e)
        {
            LabekDisplay1.ForeColor = System.Drawing.Color.DarkBlue;
        }

        private void labelDisplay1_Click_1(object sender, EventArgs e)
        {
            LabekDisplay1.ForeColor = System.Drawing.Color.DarkBlue;
        }

        private void ListR_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmmArraycs_Load(object sender, EventArgs e)
        {

        }
    }
}
