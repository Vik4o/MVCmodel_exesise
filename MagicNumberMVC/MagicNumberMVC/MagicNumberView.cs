using System;
using System.Collections.Generic;
using System.Text;

namespace MagicNumberMVC
{
    public class ConsoleView
    {
        public int ReadInt(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        public void PrintResults(List<string> results)
        {
            Console.WriteLine(string.Join(" ", results));
        }
    }
}
