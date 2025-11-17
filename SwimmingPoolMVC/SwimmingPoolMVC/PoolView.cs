using System;
using System.Collections.Generic;
using System.Text;

namespace SwimmingPoolMVC
{
    public class ConsoleView
    {
        public int ReadInt(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        public double ReadDouble(string message)
        {
            Console.Write(message);
            return double.Parse(Console.ReadLine());
        }

        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
