using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCExam
{
    public class ExamView
    {
        public int ReadNumber(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        public void ShowStatus(string status)
        {
            Console.WriteLine(status);
        }

        public void ShowDetails(string details)
        {
            if (!string.IsNullOrEmpty(details))
                Console.WriteLine(details);
        }
    }
}
