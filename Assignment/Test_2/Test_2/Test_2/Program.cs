using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2
{
    abstract class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public double Grade { get; set; }
        public abstract bool IsPassed(double grade);

    }

    class Undergraduate : Student

    {
        public override bool IsPassed(double grade)
        {
            return grade > 70.0;
        }
    }
    class Graduate : Student
    {
        public override bool IsPassed(double grade)
        {
            return grade > 80.0;
        }

    }
    class Program
    {
        static void Main()
        {

            Undergraduate undergradStudent = new Undergraduate();

            undergradStudent.Name = "Shreya";

            undergradStudent.StudentId = 2001;

            undergradStudent.Grade = 87.0;

            Graduate gradStudent = new Graduate();

            gradStudent.Name = "Prachi";

            gradStudent.StudentId = 1002;

            gradStudent.Grade = 78.0;

            Console.WriteLine($"{undergradStudent.Name} passed: {undergradStudent.IsPassed(undergradStudent.Grade)}");
            Console.WriteLine($"{gradStudent.Name} passed: {gradStudent.IsPassed(gradStudent.Grade)}");
            Console.ReadLine();
        }

    }
}

