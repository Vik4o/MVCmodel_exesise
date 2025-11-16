using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCHistogram
{
    public class HistogramView
    {
        public int ReadInt(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        public void ShowPercentages(double[] percentages)
        {
            foreach (var p in percentages)
            {
                Console.WriteLine($"{p:F2}%");
            }
        }
    }
}
