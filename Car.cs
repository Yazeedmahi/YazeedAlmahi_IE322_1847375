using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace class_2
{
    class Car
    {
       public int velocity = 0;
        


        public void CarON()
        {
            MessageBox.Show("Car has been started");
            velocity = velocity + 2;
        }

        public void CarOff()
        {
            velocity = 0;
            MessageBox.Show("Car has been stopped" + "speed is" + velocity);

        }

        public void Acc1(int plus)

        {
            if (velocity == 0)
            {
                MessageBox.Show("Please switch on the car");
            }
            else
            {
                velocity = velocity + plus;
                MessageBox.Show("Car has Accelrated by " + plus + "current spped" + velocity);
            }



        }
        public void ApllyBreak()
        {
            velocity = 1;
        }


    }
}
