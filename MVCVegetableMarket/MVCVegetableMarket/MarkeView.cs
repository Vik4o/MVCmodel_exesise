using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCVegetableMarket
{
    public class MarketController
    {
        private readonly ConsoleView view;
        private readonly VegetableMarketModel model;

        public MarketController()
        {
            view = new ConsoleView();
            model = new VegetableMarketModel();
        }

        public void Run()
        {
            model.VegetablePricePerKg = view.ReadDouble("Цена на зеленчуци (лв/кг): ");
            model.FruitPricePerKg = view.ReadDouble("Цена на плодове (лв/кг): ");
            model.VegetableKg = view.ReadInt("Кг зеленчуци: ");
            model.FruitKg = view.ReadInt("Кг плодове: ");

            double euros = model.CalculateEuroRevenue();

            view.PrintResult(euros);
        }
    }
}
