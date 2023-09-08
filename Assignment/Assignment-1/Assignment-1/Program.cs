//1.Write a C# Sharp program to accept two integers and check whether they are equal or not. 

//Test Data :
//Input 1st number: 5
//Input 2nd number: 5
//Expected Output :
//5 and 5 are equal

//2. Write a C# Sharp program to check whether a given number is positive or negative. 

//Test Data : 14
//Expected Output :
//14 is a positive number

//3.Write a C# Sharp program that takes two numbers as input and performs all operations (+,-,*,/) on them and displays the result of that operation. 

//Test Data
//Input first number: 20
//Input operation: -
//Input second number: 12
//Expected Output :
//20 - 12 = 8
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Question_1A();
            Question_1B();
            Question_1C();
        }
        static void Question_1A()
        {
            Console.WriteLine("Question 1-A:")
            Console.WriteLine("Enter no.1 = ");
            int ek = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter no.2 = ");
            int duo = Convert.ToInt32(Console.ReadLine());

            if (ek == duo)
            {
                Console.WriteLine("ek and duo are Equal");

            }
            else
            {
                Console.WriteLine("k and d are Not Equal.");
            }

        }
        static void Question_1B()
        {
            Console.WriteLine("Question 1-B:");
            Console.WriteLine("Enter the respective no. : ");
            int ek = Convert.ToInt32(Console.ReadLine());
            if (ek >= 0)
            {
                Console.WriteLine("It's positive number.");
            }
            else
            {
                Console.WriteLine("its negative");
            }
            Console.ReadLine();
        }

        static void Question_1C()
        {
            Console.WriteLine("Question 3-C:")
            Console.Write("Input first number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input operation (+, -, *, /): ");
            char operation = Convert.ToChar(Console.ReadLine());
            Console.Write("Input second number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            double result = 0.0;
            switch (operation)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    break;
                case '/':
                    if (secondNumber != 0)
                    {
                        result = firstNumber / secondNumber;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Error: Invalid operation.");
                    return;
            }
            Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {result}");
            Console.ReadLine();
        }
    }
}
