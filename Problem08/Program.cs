using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProblems
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<int> Marks { get; set; }
        public string Department { get; set; }

        public Student(string firstName, string lastName, string department, params int[] marks)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
            Marks = marks.ToList();
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} ({Department})";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student("Ahmed", "Hassan", "Computer Science", 6, 6, 6, 5),
                new Student("Omar", "Mahmoud", "Engineering", 3, 4, 5, 6),
                new Student("Mohamed", "Ali", "Computer Science", 4, 2, 3, 4),
                new Student("Fatma", "Ibrahim", "Medicine", 5, 6, 5, 5),
                new Student("Yasmin", "Abdel-Rahman", "Engineering", 5, 3, 4, 2),
                new Student("Sara", "Mostafa", "Medicine", 8, 7, 9, 8),
                new Student("Khaled", "Ahmed", "Computer Science", 2, 3, 1, 4)
            };

            // PROBLEM 8: Weak Students by Department
            // Task: Find students who have at least 2 marks ≤ 3 AND are from "Computer Science" or "Engineering" departments.
            // Display results grouped by department and sorted by student name. Use LINQ.

            /* 
             Expected Output:
             Department: Computer Science
             - Khaled Ahmed (Computer Science)
             - Mohamed Ali (Computer Science)
             
             Department: Engineering
             - Yasmin Abdel-Rahman (Engineering)
            */
            // ============================================
            // YOUR SOLUTION HERE
            var result = students.GroupBy(s => s.Department).Where(
                group => (group.Key == "Computer Science" || group.Key == "Engineering"));
            foreach (var group in result)
            {
                Console.WriteLine($"Department: {group.Key}");
                {
                    var resultGroup = group.Where(s => s.Marks.Where(m => (m <= 3)).Count() >= 2).OrderBy(s=>s.FirstName);
                    foreach(var student in resultGroup)
                    {
                        Console.WriteLine($"- {student}");
                    }
                    Console.WriteLine();
                }
            }
            // ============================================

        }
    }
}