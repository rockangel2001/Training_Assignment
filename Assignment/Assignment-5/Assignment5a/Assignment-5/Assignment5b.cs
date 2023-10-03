<<<<<<< HEAD
﻿/*2. Create a Program to count the no. of occurrences of a letter in a given string
(for example in a string called “OOPS PROGRAMMING”, O appears 3 times)
Hint: Accept a string and also the letter to be counted 
--------------------------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Assignment5b
    {
        static void Main()
        {

            Countletter();

            Console.Read();
        }
        public static int Countletter()
        {
            Console.WriteLine("Enter your sentence: ");
            string b = Console.ReadLine();
            Console.WriteLine("Enter your character you want to count: ");
            char a = Convert.ToChar(Console.ReadLine());

            int count = 0;
            foreach (char i in b)
            {
                if (i == a)
                {
                    count++;
                }

            }
            Console.WriteLine("My count is : " + count);
            return count;
        }
    }
}
    
=======
﻿/*2. Create a Program to count the no. of occurrences of a letter in a given string
(for example in a string called “OOPS PROGRAMMING”, O appears 3 times)
Hint: Accept a string and also the letter to be counted 
--------------------------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Assignment5b
    {
        static void Main()
        {

            Countletter();

            Console.Read();
        }
        public static int Countletter()
        {
            Console.WriteLine("Enter your sentence: ");
            string b = Console.ReadLine();
            Console.WriteLine("Enter your character you want to count: ");
            char a = Convert.ToChar(Console.ReadLine());

            int count = 0;
            foreach (char i in b)
            {
                if (i == a)
                {
                    count++;
                }

            }
            Console.WriteLine("My count is : " + count);
            return count;
        }
    }
}
    
>>>>>>> b99b3c9d3b6ce8d437413cb3f83363ccc54c0602
