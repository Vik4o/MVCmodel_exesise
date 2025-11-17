using System;
using System.Collections.Generic;
using System.Text;

namespace SwimmingPoolMVC
{
    public class PoolModel
    {
        public int V { get; set; }     
        public int P1 { get; set; }    
        public int P2 { get; set; }    
        public double H { get; set; }   

        public string CalculateState()
        {
            double waterFromP1 = P1 * H;
            double waterFromP2 = P2 * H;
            double totalWater = waterFromP1 + waterFromP2;

            if (totalWater <= V)
            {
                int poolPercent = (int)(totalWater / V * 100);
                int p1Percent = (int)(waterFromP1 / totalWater * 100);
                int p2Percent = (int)(waterFromP2 / totalWater * 100);

                return $"The pool is {poolPercent}% full. Pipe 1: {p1Percent}%. Pipe 2: {p2Percent}%.";
            }
            else
            {
                double overflow = totalWater - V;
                return $"For {H} hours the pool overflows with {overflow} liters.";
            }
        }
    }
}
