using System;
using System.Collections.Generic;
using System.Text;

namespace k173669_Lab1_Q6
{
    class Student: IComparable<Student>
    {

        public string Name { get; set; }

        public int YearOfBirth { get; set; }

        public int Semester { get; set; }

        public  double GPA { get; set; }

        public int CompareTo(Student student)
        {
            return student.GPA.CompareTo(this.GPA);
        }

    }
}
