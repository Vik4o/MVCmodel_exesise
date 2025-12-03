using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using izpitvane;

namespace izpitvane
{
    public class StudentService : IStudentService
    {
        private List<Student> students = new List<Student>();
        private int currentId = 1;

        public void AddStudent(string name, double grade)
        {
            students.Add(new Student(currentId++, name, grade));
        }

        public List<Student> GetAllStudents()
        {
            return students;
        }

        public Student GetBestStudent()
        {
            return students.OrderByDescending(s => s.Grade).FirstOrDefault();
        }
    }
}
