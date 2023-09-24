using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Concession_Library;

namespace Assignment_6
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TotalFare = 500;

            Class1 c = new Class1();
            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Age ");
            uint age = uint.Parse(Console.ReadLine()); //when we need positive no. only we use uint.
            c.CalculateConcession(name, age);
            Console.Read();
        }
    }
}