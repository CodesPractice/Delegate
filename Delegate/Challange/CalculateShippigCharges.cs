using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Challange
{
    internal class CalculateShippigCharges
    {
        public void CalChargesZone1(double price)
        {
            double fee = 0.0;
            fee = price * 0.25;
            Console.WriteLine("The shipping fees are  " + fee);

        }

        public void CalChargesZone2(double price)
        {
            double fee = 0.0;
            fee = (price * 0.12)+25;
            Console.WriteLine("The shipping fees are  " + fee);

        }

        public void CalChargesZone3(double price)
        {
            double fee = 0.0;
            fee = price * 0.08;
            Console.WriteLine("The shipping fees are  " + fee);

        }

        public void CalChargesZone4(double price)
        {
            double fee = 0.0;
            fee = (price * 0.04) + 25;
            Console.WriteLine("The shipping fees are  " + fee);

        }


    }
}
