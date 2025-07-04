using Delegate.BasicDelegates;

namespace Delegate
{
    internal class Program
    {
        public delegate void GreetingDelegate(string name);

        public delegate int CalculateTwoNumbersDelegate(int val1, int val2);

        static void Main(string[] args)
        {
            Greeting greetingObj = new Greeting();
            GreetingDelegate greet = greetingObj.SayHi;
            greet("Andrew ");

            Console.WriteLine();


           Calculation CalObj = new Calculation();
            CalculateTwoNumbersDelegate AddNumsObj = CalObj.Addition;
            CalculateTwoNumbersDelegate DeductNumsObj = CalObj.Deduction;
            CalculateTwoNumbersDelegate MulNumsObj = CalObj.Multiplication;
            CalculateTwoNumbersDelegate DivNumsObj = CalObj.Division;

            Console.WriteLine("Additions : " + AddNumsObj(10, 20));
            Console.WriteLine("Deduction : " + DeductNumsObj(10, 20));
            Console.WriteLine("Muliplication : " + MulNumsObj(10, 20));
            Console.WriteLine("Division : " + DivNumsObj(100, 20));
            

            Console.ReadKey();
        }
    }
}
