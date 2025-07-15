using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cairoStudents = new List<string>
            {
                "Ahmed Hassan",
                "Fatma Ibrahim",
                "Omar Mahmoud",
                "Yasmin Abdel-Rahman",
                "Mohamed Ali"
            };

            List<string> alexandriaStudents = new List<string>
            {
                "Omar Mahmoud",
                "Nour El-Sayed",
                "Yasmin Abdel-Rahman",
                "Khaled Farouk",
                "Amr Mostafa"
            };

            List<string> gizaStudents = new List<string>
            {
                "Ahmed Hassan",
                "Nour El-Sayed",
                "Abdel-Rahman El-Masry"
            };

            /*
             * PROBLEM 12: Set Operations
             * 
             * Task A: Find students who are in both Cairo and Alexandria (Intersect)
             * Task B: Find all unique students from all cities (Union)
             * Task C: Find students who are in Cairo but not in Alexandria (Except)
             * Task D: Remove duplicate names from Cairo students list (Distinct)
             * 
             * Expected Output:
             * Intersection (Cairo ∩ Alexandria):
             * Omar Mahmoud
             * Yasmin Abdel-Rahman
             * 
             * Union (All unique students):
             * Ahmed Hassan
             * Fatma Ibrahim
             * Omar Mahmoud
             * Yasmin Abdel-Rahman
             * Mohamed Ali
             * Nour El-Sayed
             * Khaled Farouk
             * Amr Mostafa
             * Abdel-Rahman El-Masry
             * 
             * Cairo Except Alexandria:
             * Ahmed Hassan
             * Fatma Ibrahim
             * Mohamed Ali
             */

            // ============================================
            // YOUR SOLUTION HERE
            var result1 = cairoStudents.Intersect(alexandriaStudents);
            var result2 = cairoStudents.Union(alexandriaStudents).Union(gizaStudents);
            var result3 = cairoStudents.Except(alexandriaStudents);
            var result4 = cairoStudents.Distinct();
            Console.WriteLine("Intersection (Cairo ∩ Alexandria):");
            foreach(var s in result1)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Union (All unique students):");
            foreach (var s in result2)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Cairo Except Alexandria:");
            foreach (var s in result3)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("distinct cairo students");
            foreach (var s in result4)
            {
                Console.WriteLine(s);
            }
            // ============================================

        }
    }
}
