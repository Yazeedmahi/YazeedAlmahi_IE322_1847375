using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
 using System.Reflection;
namespace class_2
{
    public partial class FrmPicterBox : Form
    {
        Assembly _assembly;
        Stream _imageStream;
        System.Drawing.Graphics memegraphic;
           
        public FrmPicterBox()
        {
            InitializeComponent();


            memegraphic = this.Pictry.CreateGraphics();//
        }

        private void BtnLoadImage_Click(object sender, EventArgs e)
        {
            try
            {
                Pictry.Image = Image.FromFile("C:\\Users\\yazee\\Pictures\\download.jpg");
            }
            catch
            {
                MessageBox.Show("Ain't no image found homie");
            }
            }

        private void Pictry_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnLoadImage2_Click(object sender, EventArgs e)
        {
            try
            {
                Pictry2.Image = Image.FromStream(_imageStream);
            }
            catch
            {
                MessageBox.Show("The resource door ani't open");
            }
           
        }

        private void Pictry2_Click(object sender, EventArgs e)
        {

        }

        private void FrmPicterBox_Load(object sender, EventArgs e)
        {
            _assembly = Assembly.GetExecutingAssembly(); //set the assembly object
            _imageStream = _assembly.GetManifestResourceStream("class-2.res.Image1.jpg");
        }
    }
}
