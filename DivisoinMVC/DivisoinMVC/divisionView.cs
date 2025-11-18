using System;
using System.Collections.Generic;
using System.Text;

namespace DivisoinMVC
{
    public class ConsoleView
    {
        public int ReadInt(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        public void PrintPercent(double percent)
        {
            Console.WriteLine($"{percent:F2}%");
        }
    }
}
