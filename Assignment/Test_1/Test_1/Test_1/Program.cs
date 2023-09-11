/*

1. Write a C# Sharp program to remove the character at a given position in the string.
The given position will be in the range 0..(string length -1) inclusive.

Sample Input:

"Python", 1

"Python", 0

"Python", 4

Expected Output:

Pthon

ython

Pythn
-----------------------------------------------------------------------------------------------
2. Write a C# Sharp program that prints the multiplication table of a number as input.

Test Data:

Enter the number: 5

Expected Output:

5 * 0 = 0

5 * 1 = 5

5 * 2 = 10

5 * 3 = 15

....

5 * 10 = 50  */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Question_A();
            Question_B();
        }
        static void Question_A()
        {
            Console.WriteLine(test("Python", 1));
            Console.WriteLine(test("Python", 0));
            Console.WriteLine(test("Python", 4));
            Console.ReadLine();
        }
        public static string test(string str, int n)
        {
            return str.Remove(n, 1); // Remove() method remove the character in a string
                                     // and return a new string.
        }
        static void Question_B()
        {
            int x;
            int result;
            Console.WriteLine("Enter a Number: ");
            x = Convert.ToInt32(Console.ReadLine());
            result = x * 1;
            Console.WriteLine("{0} *{1} = {2}", x, 1, result);
            result = x * 2;
            Console.WriteLine("{0} *{1} = {2}", x, 2, result);
            result = x * 3;
            Console.WriteLine("{0} *{1} = {2}", x, 3, result);
            result = x * 4;
            Console.WriteLine("{0} *{1} = {2}", x, 4, result);
            result = x * 5;
            Console.WriteLine("{0} *{1} = {2}", x, 5, result);
            result = x * 6;
            Console.WriteLine("{0} *{1} = {2}", x, 6, result);
            result = x * 7;
            Console.WriteLine("{0} *{1} = {2}", x, 7, result);
            result = x * 8;
            Console.WriteLine("{0} *{1} = {2}", x, 8, result);
            result = x * 9;
            Console.WriteLine("{0} *{1} = {2}", x, 9, result);
            result = x * 10;
            Console.WriteLine("{0} *{1} = {2}", x, 10, result);
            Console.ReadLine();
        }
    }
}