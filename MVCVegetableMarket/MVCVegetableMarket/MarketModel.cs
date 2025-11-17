using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCVegetableMarket
{
    public class VegetableMarketModel
    {
        public double VegetablePricePerKg { get; set; }
        public double FruitPricePerKg { get; set; }
        public int VegetableKg { get; set; }
        public int FruitKg { get; set; }

        public double CalculateEuroRevenue()
        {
            double totalLeva = (VegetablePricePerKg * VegetableKg)
                             + (FruitPricePerKg * FruitKg);

            return totalLeva / 1.94;
        }
    }
}
