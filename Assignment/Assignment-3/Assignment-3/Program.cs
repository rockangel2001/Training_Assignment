//Strings Assignment
//1.	Write a program in C# to accept a word from the user and display the length of it.
//2.	Write a program in C# to accept a word from the user and display the reverse of it. 
//3.	Write a program in C# to accept two words from user and find out if they are same. 

//Hint: Use functions of the string class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Question_3A();
            Question_3B();
            Question_3C();
        }
        static void Question_3A()
        {
            Console.WriteLine("Question_3A");
            Console.WriteLine("Enter a Word ");
            string input = Console.ReadLine();
            Console.WriteLine($"The Length of word is {input.Length}");
        }

        static void Question_3B()
        {
            Console.WriteLine("Question_3B");
            Console.WriteLine("Enter a Word ");
            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversedword = new string(charArray);

            Console.WriteLine("Reversed word is : " + reversedword);
        }
        static void Question_3C()
        {
            Console.WriteLine("Question_3C");
            Console.WriteLine("Enter the 1st Word : ");
            string first_1 = Console.ReadLine();
            Console.WriteLine("Enter the 2nd Word : ");
            string second_2 = Console.ReadLine();
            if (first_1 == second_2)
            {
                Console.WriteLine($"1st Word {first_1} and 2nd Word {second_2} are Same.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"1st Word {first_1} and 2nd Word {second_2} are Not Same.");
                Console.ReadLine();
            }
        }
    }
}
