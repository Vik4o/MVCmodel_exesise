using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izpitvane
{
    public interface IStudentService
    {
        void AddStudent(string name, double grade);
        List<Student> GetAllStudents();
        Student GetBestStudent();
    }
}
