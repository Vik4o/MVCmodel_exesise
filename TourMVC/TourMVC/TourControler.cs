using System;
using System.Collections.Generic;
using System.Text;

namespace TourMVC
{
    public class TravelController
    {
        private readonly ConsoleView view;
        private readonly TravelModel model;

        public TravelController()
        {
            view = new ConsoleView();
            model = new TravelModel();
        }

        public void Run()
        {
            model.Budget = view.ReadDouble("Въведи бюджет: ");
            model.Season = view.ReadString("Въведи сезон (summer/winter): ");

            model.CalculateTrip();

            view.PrintResult(model.Destination, model.VacationType, model.MoneySpent);
        }
    }
}
