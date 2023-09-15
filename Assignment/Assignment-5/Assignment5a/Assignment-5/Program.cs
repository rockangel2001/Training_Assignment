/*General:
------------
1.Create a Class Program which would be used to accepts two  Strings - FirstName and LastName and 
call the static method Display() that displays the first name in one line and the LastName in
the second line after converting the same to upper case.
----------------------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Display();
        }
        public static void Display()
        {
            Console.WriteLine("Enter your First Name");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter your First Name");
            string LastName = Console.ReadLine();
            string f = FirstName.ToUpper();
            string l = LastName.ToUpper();
            Console.Write(f + "\n" + l);
            Console.ReadLine();
        }
    }
}
