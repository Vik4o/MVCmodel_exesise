using System;
using System.Collections.Generic;
using System.Text;

namespace MVCPriceForTicket
{
    public class TransportController
    {
        private TransportView view;
        private TransportModel model;

        public TransportController()
        {
            view = new TransportView();
            model = new TransportModel();
        }

        public void Run()
        {
            model.Kilometers = view.ReadKilometers();
            model.DayOrNight = view.ReadDayOrNight();

            double cheapest = model.GetCheapestTransport();

            view.ShowResult(cheapest);
        }
    }
}
