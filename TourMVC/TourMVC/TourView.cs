using System;
using System.Collections.Generic;
using System.Text;

namespace TourMVC
{
    public class ConsoleView
    {
        public double ReadDouble(string message)
        {
            Console.Write(message);
            return double.Parse(Console.ReadLine());
        }

        public string ReadString(string message)
        {
            Console.Write(message);
            return Console.ReadLine().ToLower();
        }

        public void PrintResult(string destination, string type, double money)
        {
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{type} - {money:F2}");
        }
    }
}
