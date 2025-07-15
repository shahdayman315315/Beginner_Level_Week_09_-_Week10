using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProblems
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GroupNumber { get; set; }

        public Student(string firstName, string lastName, int groupNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            GroupNumber = groupNumber;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student("Ahmed", "Hassan", 1),
                new Student("Omar", "Mahmoud", 2),
                new Student("Mohamed", "Ali", 1),
                new Student("Fatma", "Ibrahim", 2),
                new Student("Yasmin", "Abdel-Rahman", 2),
                new Student("Nour", "El-Sayed", 3),
                new Student("Khaled", "Farouk", 3)
            };

            /*
             * PROBLEM 4: Count Students by Group
             * 
             * Task: Count how many students are in each group. Order by group number. Use LINQ.
             * 
             * Expected Output:
             * Group 1: 2 students
             * Group 2: 3 students
             * Group 3: 2 students
             */

            // ============================================
            // YOUR SOLUTION HERE
            var result = students.GroupBy(s => s.GroupNumber).OrderBy(group=>group.Key);
            foreach(var group in result)
            {
                Console.WriteLine($"Group {group.Key}: { group.Count()} Students");
            }
            // ============================================

        }
    }
}
