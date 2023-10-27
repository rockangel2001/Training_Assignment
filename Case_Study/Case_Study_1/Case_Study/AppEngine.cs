using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    public class AppEngine
    {
        private List<Student> students = new List<Student>();
        private List<Course> courses = new List<Course>();
        private List<Enrollment> enrollments = new List<Enrollment>();

        public AppEngine()
        {
            // Predefined students
            students.Add(new Student(1, "shahbaz", new DateTime(2000, 5, 15)));
            students.Add(new Student(2, "Alam", new DateTime(1999, 8, 20)));

            // Predefined courses
            courses.Add(new Course(101, "Mathematics"));
            courses.Add(new Course(102, "Science"));
            courses.Add(new Course(103, "Computer"));
            courses.Add(new Course(104, "Grammer"));

        }

        //Introduce new course
        public void Introduce(Course course)
        {
            courses.Add(course);
        }

        //Register new Student
        public void Register(Student student)
        {
            students.Add(student);
        }

        //fetching list of enrollments
        public List<Enrollment> ListOfEnrollments()
        {
            return enrollments;

        }

        //fetching list of students
        public List<Student> ListOfStudents()
        {
            return students;
        }

        //fetching list of course
        public List<Course> ListOfCourses()
        {
            return courses;
        }

        //to enroll student in course
        public void Enroll(Student student, Course course)
        {
            DateTime enrollmentDate = DateTime.Now; //enrollment date is the current date
            enrollments.Add(new Enrollment(student, course, enrollmentDate));
        }
    }
}