using System;
using System.Collections.Generic;

namespace k173669_Lab1_Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student> {
            new Student{Name="Bilal", YearOfBirth=1999, Semester=8, GPA=3.69},
            new Student{Name="Akmal", YearOfBirth=1998, Semester=7, GPA=2.88},
            new Student{Name="Khan", YearOfBirth=1969, Semester=6, GPA=3.91},
            new Student{Name="Muhammad", YearOfBirth=2001, Semester=8, GPA=2.69},
            new Student{Name="K173669", YearOfBirth=2021, Semester=3, GPA=3.61},
            };

            students.Sort();

            foreach(Student student in students)
            {

                Console.WriteLine($"{student.Name} {student.YearOfBirth} {student.Semester} {student.GPA}");
            }


        }
    }
}
