
namespace Delegate.BasicDelegates
{
    internal class Calculation
    {
        // implementation of delegate methods
        // these are match to the delegate signature
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
