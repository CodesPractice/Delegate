using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.BasicDelegates
{
    internal class Calculation
    {
        public int Addition(int x, int y)
        {
            return x + y;
        }

        public int Deduction(int x, int y)
        {
            if (x > y)
                return x - y;
            else
                return y - x;
        }

        public int Multiplication(int x, int y)
        {
            return x * y;
        }

        public int Division(int x, int y)
        {
            if (y != 0)
                return x / y;
            else
                return 0;
        }
    }
}
