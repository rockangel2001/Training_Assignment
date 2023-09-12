﻿/* Question 2: Create a class called student which has data members like rollno, name,
class, Semester, branch, int[] marks = new int marks [5](marks of 5 subjects )

-Pass the details of student like rollno, name, class, SEM, branch in constructor

- For marks write a method called GetMarks() and give marks for all 5 subjects

-Write a method called displayresult, which should calculate the average marks

-If marks of any one subject is less than 35 print result as failed
-If marks of all subject is >35, but average is < 50 then also print result as failed
-If avg > 50 then print result as passed.

-Write a DisplayData() method to display all values.  */
//--------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{




    class Student
    {
        private int roll_number;
        private string name;
        private string student_class;
        private string semester;
        private string branch;
        private int[] marks = new int[5];

        public Student(int rollNo, string name, string studentClass, string semester, string branch)
        {
            this.roll_number = rollNo;
            this.name = name;
            this.student_class = studentClass;
            this.semester = semester;
            this.branch = branch;
        }

        public void GetMarks(int[] subjectMarks)
        {
            if (subjectMarks.Length != 5)
            {
                Console.WriteLine("Invalid number of subject marks. Please provide marks for all 5 subjects.");
                return;
            }

            for (int i = 0; i < 5; i++)
            {
                marks[i] = subjectMarks[i];
            }
        }

        public void DisplayResult()
        {
            double average = CalculateAverage();

            bool failed = false;

            for (int i = 0; i < 5; i++)
            {
                if (marks[i] < 35)
                {
                    failed = true;
                    break;
                }
            }

            if (!failed && average < 50)
            {
                failed = true;
            }

            if (failed)
            {
                Console.WriteLine("Result: Failed. Try Hard :-)");
            }
            else
            {
                Console.WriteLine("Result: Passed.Yeah Great :-)");
            }

            Console.WriteLine($"Roll No: {roll_number}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Class: {student_class}");
            Console.WriteLine($"Semester: {semester}");
            Console.WriteLine($"Branch: {branch}");
            Console.WriteLine($"Average Marks: {average:F2}");
        }

        private double CalculateAverage()
        {
            double sum = 0;

            for (int i = 0; i < 5; i++)
            {
                sum += marks[i];
            }

            return sum / 5;
        }
    }

    class Program_4B
    {
        static void Main()
        {
            Student student = new Student(162, "Shreya", "BBDNIIT", "4th", "CSE");

            Console.WriteLine("Enter marks for 5 subjects:");
            int[] subjectMarks = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Subject {i + 1} marks: ");
                subjectMarks[i] = int.Parse(Console.ReadLine());
            }

            student.GetMarks(subjectMarks);

            student.DisplayResult();
            Console.ReadLine();
        }
    }
}