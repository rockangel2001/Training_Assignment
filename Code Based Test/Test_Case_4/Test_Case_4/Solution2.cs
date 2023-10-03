/*2. Write a console program that uses delegates to call Calculator Functionalities like 
 * 1. Addition, 2. Subtraction and 3. Multiplication 
 * by taking 2 integers and returns the answer to the user.
 * You should display the return values accordingly.*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Case_4
{
    // Declare a delegate for calculator functions
    delegate int CalculatorDelegate(int a, int b);

    class Solution2
    {
        static void Main()
        {
            // Prompt the user for two integers
            Console.Write("Please enter your first integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter your second integer: ");
            int num2 = int.Parse(Console.ReadLine());

            // Create delegate instances for the calculator functions
            CalculatorDelegate addDelegate = Add;
            CalculatorDelegate subtractDelegate = Subtract;
            CalculatorDelegate multiplyDelegate = Multiply;

            // Perform calculations using the delegates
            int sum = PerformOperation(addDelegate, num1, num2);
            int difference = PerformOperation(subtractDelegate, num1, num2);
            int product = PerformOperation(multiplyDelegate, num1, num2);

            // Display the results
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
            Console.ReadLine();
        }

        // Calculator functions
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        // Perform the operation using the delegate
        static int PerformOperation(CalculatorDelegate calculator, int a, int b)
        {
            return calculator(a, b);
        }
    }
}

