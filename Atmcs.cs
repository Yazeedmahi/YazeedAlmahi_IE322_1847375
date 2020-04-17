using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_2
{
    class Atmcs
    {
        int b = 500;
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

    }
}
