using Delegate.BasicDelegates;

namespace Delegate
{
    internal class Program
    {
        // Define a delegate for greeting messages
        public delegate void GreetingDelegate(string name);

        // Define a delegate for mathematical operations on two integers
        public delegate int CalculateTwoNumbersDelegate(int val1, int val2);

        static void Main(string[] args)
        {
            // Create Greeting object and assign the SayHi method to the delegate
            Greeting greetingObj = new Greeting();
            GreetingDelegate greet = greetingObj.SayHi;

            // Call the delegate to print the greeting message
            greet("Andrew");

            Console.WriteLine();

            // Create Calculation object and assign each method to the corresponding delegate
            Calculation CalObj = new Calculation();
            CalculateTwoNumbersDelegate AddNumsObj = CalObj.Addition;
            CalculateTwoNumbersDelegate DeductNumsObj = CalObj.Deduction;
            CalculateTwoNumbersDelegate MulNumsObj = CalObj.Multiplication;
            CalculateTwoNumbersDelegate DivNumsObj = CalObj.Division;

            // Perform operations using delegates and display the results

            Console.WriteLine("Additions : " + AddNumsObj(10, 20));

            // Special case: Deduction returns absolute difference (always positive)
            Console.WriteLine("Deduction : " + DeductNumsObj(10, 20));

            Console.WriteLine("Multiplication : " + MulNumsObj(10, 20));

            // Special case: Division checks for divide-by-zero internally and returns 0 if y == 0
            Console.WriteLine("Division : " + DivNumsObj(100, 20));


            Console.ReadKey();
        }
    }
}
