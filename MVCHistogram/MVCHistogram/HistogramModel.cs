using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCHistogram
{
    public class HistogramModel
    {
        public int Count { get; set; }
        public List<int> Numbers { get; set; } = new List<int>();

        public double[] CalculatePercentages()
        {
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;

            foreach (var num in Numbers)
            {
                if (num < 200)
                    p1++;
                else if (num <= 399)
                    p2++;
                else if (num <= 599)
                    p3++;
                else if (num <= 799)
                    p4++;
                else
                    p5++;
            }

            return new double[]
            {
                p1 * 100.0 / Count,
                p2 * 100.0 / Count,
                p3 * 100.0 / Count,
                p4 * 100.0 / Count,
                p5 * 100.0 / Count
            };
        }
    }
}
