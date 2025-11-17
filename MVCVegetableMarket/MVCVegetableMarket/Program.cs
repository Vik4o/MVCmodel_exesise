using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCVegetableMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var controller = new MarketController();
            controller.Run();
        }
    }
}
