using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_15_Course_Registration_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> courses = new List<string>(6);
            int attempts = 0;
            const int maxCourses = 6;

            Console.WriteLine("Course Registration System");
            Console.WriteLine("--------------------------");
            Console.WriteLine($"Please register up to {maxCourses} courses");
            Console.WriteLine("Each course code must be exactly 5 characters long");
            Console.WriteLine("Duplicate course codes are not allowed\n");

            while (attempts < maxCourses)
            {
                Console.Write($"Enter course code #{attempts + 1}: ");
                string input = Console.ReadLine();
                if (input.Length != 5)
                {
                    Console.WriteLine("Error: Course code must be exactly 5 characters\n");
                    continue;
                }
                if (courses.Contains(input))
                {
                    Console.WriteLine("Error: This course code already exists\n");
                    continue;
                }
                courses.Add(input);
                Console.WriteLine($"Success: Course '{input}' registered\n");
                attempts++;
            }
            Console.WriteLine("\nRegistration Complete!");
            Console.WriteLine("Registered Courses:");
            foreach (string course in courses)
            {
                Console.WriteLine(course);
            }
        }
    }
}






