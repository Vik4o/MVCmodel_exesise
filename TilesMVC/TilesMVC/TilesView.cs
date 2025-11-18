using System;
using System.Collections.Generic;
using System.Text;

namespace TilesMVC
{
    public class ConsoleView
    {
        public double ReadDouble(string message)
        {
            Console.Write(message);
            return double.Parse(Console.ReadLine());
        }

        public void PrintResult(double tiles, double time)
        {
            Console.WriteLine(tiles);
            Console.WriteLine(time);
        }
    }
}
