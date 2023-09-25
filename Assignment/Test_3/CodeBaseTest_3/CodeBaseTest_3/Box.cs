/*2. Write a class Box that has Length and breadth as its members. 
 * Write a function that adds 2 box objects and stores in the 3rd.
 * Display the 3rd object details. Create a Test class to execute the above.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBaseTest_3
{
    class Box
    {
        public double Len;
        public double Bre;
        public Box()
        {
            Len = 0;
            Bre = 0;
        }
        public Box(double len, double bre)
        {
            Len = len;
            Bre = bre;
        }
        public static Box Add(Box box1, Box box2)
        {
            double sumLen = box1.Len + box2.Len;
            double sumBre = box1.Bre + box2.Bre;
            return new Box(sumLen, sumBre);
        }
        public void Display()
        {
            Console.WriteLine($" Length : {Len}, Breadth : {Bre}");
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Box box1 = new Box(8.0, 16.4);
            Box box2 = new Box(2.9, 9.4);
            Box box3 = Box.Add(box1, box2);
            Console.WriteLine("Box 1: ");
            box1.Display();
            Console.WriteLine("Box 2: ");
            box2.Display();
            Console.WriteLine("Box 3: ");
            box3.Display();
            Console.ReadLine();
        }
    }
}
