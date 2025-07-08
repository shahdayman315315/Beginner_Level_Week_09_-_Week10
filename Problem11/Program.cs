using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProblems
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CourseId { get; set; }

        public Student(int id, string firstName, string lastName, int courseId)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            CourseId = courseId;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }

    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Instructor { get; set; }

        public Course(int id, string name, string instructor)
        {
            Id = id;
            Name = name;
            Instructor = instructor;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student(1, "Ahmed", "Hassan", 101),
                new Student(2, "Fatma", "Ibrahim", 102),
                new Student(3, "Omar", "Mahmoud", 101),
                new Student(4, "Yasmin", "Abdel-Rahman", 103),
                new Student(5, "Mohamed", "Ali", 102)
            };

            List<Course> courses = new List<Course>
            {
                new Course(101, "Computer Science", "Dr. Amr Mostafa"),
                new Course(102, "Mathematics", "Dr. Nour El-Sayed"),
                new Course(103, "Physics", "Dr. Khaled Farouk")
            };

            /*
             * PROBLEM 11: Join Operations
             * 
             * Task: Join students with their courses and display student name with course name and instructor.
             *       Order by course name, then by student first name.
             * 
             * Expected Output:
             * Ahmed Hassan - Computer Science (Dr. Amr Mostafa)
             * Omar Mahmoud - Computer Science (Dr. Amr Mostafa)
             * Fatma Ibrahim - Mathematics (Dr. Nour El-Sayed)
             * Mohamed Ali - Mathematics (Dr. Nour El-Sayed)
             * Yasmin Abdel-Rahman - Physics (Dr. Khaled Farouk)
             */

            // ============================================
            // YOUR SOLUTION HERE
            // ============================================



        }
    }
}
