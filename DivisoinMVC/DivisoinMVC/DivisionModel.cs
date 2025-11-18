using System;
using System.Collections.Generic;
using System.Text;

namespace DivisoinMVC
{
    public class DivisionModel
    {
        public int N { get; set; }
        public List<int> Numbers { get; set; } = new List<int>();

        public double P1 { get; set; } 
        public double P2 { get; set; } 
        public double P3 { get; set; } 

        public void Calculate()
        {
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;

            foreach (var num in Numbers)
            {
                if (num % 2 == 0) count2++;
                if (num % 3 == 0) count3++;
                if (num % 4 == 0) count4++;
            }

            P1 = (double)count2 / N * 100;
            P2 = (double)count3 / N * 100;
            P3 = (double)count4 / N * 100;
        }
    }
}
