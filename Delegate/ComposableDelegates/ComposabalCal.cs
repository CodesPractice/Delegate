using System;

namespace Delegate.ComposableDelegates
{
    // Use 'void' so we can compose and see all outputs

    internal class ComposabalCal
    {
        public void Addition(int x, int y)
        {
            Console.WriteLine("Addition is " + (x + y));
        }

        public void Deduction(int x, int y)
        {
            int ans = x > y ? x - y : y - x;
            Console.WriteLine("Deduction is " + ans);
        }

        public void Multiplication(int x, int y)
        {
            Console.WriteLine("Multiplication is " + (x * y));
        }

        public void Division(int x, int y)
        {
            int ans = y != 0 ? x / y : 0;
            Console.WriteLine("Division is " + ans);
        }
    }
}
