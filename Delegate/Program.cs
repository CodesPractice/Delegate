using Delegate.BasicDelegates;

namespace Delegate
{
    internal class Program
    {
        public delegate void GreetingDelegateObj(string name);

        public delegate int CalculateTwoNumbers(int val1, int val2);

        static void Main(string[] args)
        {
            Greeting greetingObj = new Greeting();
            GreetingDelegateObj greet = greetingObj.SayHi;
            greet("Andrew ");



            Console.ReadKey();
        }
    }
}
