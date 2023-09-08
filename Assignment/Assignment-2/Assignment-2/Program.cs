//Arrays

//Write a  Program to assign integer values to an array  and then print the following
//a.	 Average value of Array elements
//b.	Minimum and Maximum value in an array 
    
//2.	Write a program in C# to accept ten marks and display the 
//		following
//a.	Total
//b.	Average
//c.	Minimum marks
//d.	Maximum marks
//e.	Display marks in ascending order
//f.	Display marks in descending order
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Question_2A();
            Question_2B();
        }
        static void Question_2A()
        {
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            double sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            double average = sum / size;
            Console.WriteLine($"Average value of array elements: {average}");
            int min = arr[0];
            int max = arr[0];
            foreach (int num in arr)
            {
                if (num < min)
                {
                    min = num;
                }
                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine($"Minimum value in the array: {min}");
            Console.WriteLine($"Maximum value in the array: {max}");
        }

        static void Question_2B()
        {
            int[] marks = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter mark {i + 1}: ");
                marks[i] = int.Parse(Console.ReadLine());
            }
            int total = 0;
            foreach (int mark in marks)
            {
                total += mark;
            }
            double average = (double)total / 10;
            int min = marks[0];
            int max = marks[0];
            foreach (int mark in marks)
            {
                if (mark < min)
                {
                    min = mark;
                }
                if (mark > max)
                {
                    max = mark;
                }
            }

            Array.Sort(marks);

            // Display results
            Console.WriteLine($"Total marks: {total}");
            Console.WriteLine($"Average marks: {average:F2}");
            Console.WriteLine($"Minimum marks: {min}");
            Console.WriteLine($"Maximum marks: {max}");
            Console.WriteLine("Marks in ascending order:");
            foreach (int mark in marks)
            {
                Console.Write($"{mark} ");
            }
            Console.WriteLine();

            Array.Reverse(marks);
            Console.WriteLine("Marks in descending order:");
            foreach (int mark in marks)
            {
                Console.Write($"{mark} ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
    

