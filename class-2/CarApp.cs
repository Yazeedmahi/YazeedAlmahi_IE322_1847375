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
    public partial class CarApp : Form
    {
        Car Car1 = new Car();
        Car Car2 = new Car();

        Truck Truck1 = new Truck();


        public CarApp()
        {
            InitializeComponent();
        }

        private void BtnStartCar_Click(object sender, EventArgs e)
        {
            Car1.CarON();
        }

        private void BtnStopCar_Click(object sender, EventArgs e)
        {
            Car1.CarOff();

        }

        private void BtnAccelrate_Click(object sender, EventArgs e)
        {
            Car1.Acc1(20);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Car2.CarON();
        }

        private void BtnAccelrateCar2_Click(object sender, EventArgs e)
        {
            Car2.Acc1(20);
        }

        private void StopCar2_Click(object sender, EventArgs e)
        {
            Car2.CarOff();

        }

        private void BtnStartTruck_Click(object sender, EventArgs e)
        {
            Truck1.TruckON();
        }

        private void BtnStopTruck_Click(object sender, EventArgs e)
        {

            Truck1.TruckOff();
        }

        private void BtnAccelrateTruck_Click(object sender, EventArgs e)
        {
            Truck1.Acc11(30);
        }
    }
}
