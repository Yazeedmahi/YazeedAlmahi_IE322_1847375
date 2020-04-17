using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_2
{
    class Truck
    {
        public int velocity = 0;



        public void TruckON()
        {
            MessageBox.Show("Truck has been started");
            velocity = velocity + 2;
        }

        public void TruckOff()
        {
            velocity = 0;
            MessageBox.Show("Truck has been stopped" + "speed is" + velocity);

        }

        public void Acc11(int plus)

        {
            if (velocity == 0)
            {
                MessageBox.Show("Please switch on the Truck");
            }
            else
            {
                velocity = velocity + plus;
                MessageBox.Show("Truck has Accelrated by " + plus + "current spped" + velocity);
            }



        }
        public void ApllyBreak1()
        {
            velocity = 1;
        }


    }
}

