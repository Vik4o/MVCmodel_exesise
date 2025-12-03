using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izpitvane
{
    public class Student
    {      
        public string Name { get; }
        public double Grade { get; }

        public Student(int id, string name, double grade)
        {
            Name = name;
            Grade = grade;
        }

        public void NegativeGrade()
        {
            if (Grade < 0)
            {
                throw new Exception("Grade must be positive");
            }
        }
        
    }
}
