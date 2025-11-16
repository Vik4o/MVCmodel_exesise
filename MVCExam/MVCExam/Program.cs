using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExamController controller = new ExamController();
            controller.Run();
        }
    }
}
