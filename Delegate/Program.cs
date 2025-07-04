using System.Reflection.Metadata;
using Delegate.BasicDelegates;
using Delegate.Challange;
using Delegate.ComposableDelegates;

namespace Delegate
{
    internal class Program
    {
        //Basic Delegate

        // Define a delegate for greeting messages
        public delegate void GreetingDelegate(string name);

        // Define a delegate for mathematical operations on two integers
        public delegate int CalculateTwoNumbersDelegate(int val1, int val2);
        //-----------------------------------------------------------------------------

        //Anonymous Delegate

        // Define a delegate for calculte age
        public delegate int CalculateAgeDelegate(int birthYear);
        //-----------------------------------------------------------------------------

        //Anonymous Delegate

        // Define a delegate for calculte age
        public delegate void CalculateTwoNumbersComposableDelegate(int val1, int val2);
        //-----------------------------------------------------------------------------


        // Delegate Challange

        // Define a delegate for calculte shipping charges
        public delegate void CalculateShippigChargesDelegate(double price);
        //-----------------------------------------------------------------------------


        static void Main(string[] args)
        {
            CalculateShippigCharges calculateShippigCharges = new CalculateShippigCharges();

            CalculateShippigChargesDelegate CalChargesDelObjZ1 = calculateShippigCharges.CalChargesZone1;
            CalculateShippigChargesDelegate CalChargesDelObjZ2 = calculateShippigCharges.CalChargesZone2;
            CalculateShippigChargesDelegate CalChargesDelObjZ3 = calculateShippigCharges.CalChargesZone3;
            CalculateShippigChargesDelegate CalChargesDelObjZ4 = calculateShippigCharges.CalChargesZone4;

            string price = "";
            string zone = "";

     
            while (price.ToLower() != "exit") 
            {
                Console.Write("What is the destination Zone? : ");
                zone = Console.ReadLine()!;
                if (zone == "exit")
                    break;
                Console.Write("What is the item price ? : ");
                price = Console.ReadLine()!;

                switch (zone.ToLower())
                {
                    case "zone1":
                        CalChargesDelObjZ1(double.Parse(price));
                        break;
                    case "zone2":
                        CalChargesDelObjZ2(double.Parse(price));
                        break;
                    case "zone3":
                        CalChargesDelObjZ3(double.Parse(price));
                        break;
                    case "zone4":
                        CalChargesDelObjZ4(double.Parse(price));
                        break;
                    default:
                        Console.WriteLine("Invalid zone entered.");
                        break;
                }

            } 



            // BasicDelegate();

            // AnonymousDelegate();

            // ComposableDelegate();

            Console.ReadKey();

        }

        public static void BasicDelegate()
        {
            Console.WriteLine("Basic Delegtes ");
            Console.WriteLine("--------------------------------");

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

            Console.WriteLine("\n\n");
        }

        public static void AnonymousDelegate()
        {
            Console.WriteLine("Anonymous Delegate ");
            Console.WriteLine("--------------------------------");
            // Implement and assign an anonymous delegate directly to the delegate variable
            CalculateAgeDelegate DelObj = delegate (int birthYear)
            {
                return (2025 - birthYear);
            };
            Console.WriteLine("My age is " + DelObj(1988).ToString());

            Console.WriteLine("\n\n");
        }

        public static void ComposableDelegate()
        {
            Console.WriteLine("Composable Delegate  ");
            Console.WriteLine("--------------------------------");


            ComposabalCal calObj = new ComposabalCal();

            // Create individual delegate instances
            CalculateTwoNumbersComposableDelegate AddNumsObj = calObj.Addition;
            CalculateTwoNumbersComposableDelegate DeductNumsObj = calObj.Deduction;
            CalculateTwoNumbersComposableDelegate MulNumsObj = calObj.Multiplication;
            CalculateTwoNumbersComposableDelegate DivNumsObj = calObj.Division;

            // Compose them into one delegate
            CalculateTwoNumbersComposableDelegate AllCal = AddNumsObj + DeductNumsObj + MulNumsObj + DivNumsObj;

            // Invoke all calculations at once
            AllCal(10, 2);

        }


        
    }
}
