using System;
using System.Collections.Generic;
using System.Text;

namespace MVCPriceForTicket
{
    public class TransportModel
    {
        public int Kilometers { get; set; }
        public string DayOrNight { get; set; }

        public double TaxiPrice()
        {
            double startFee = 0.70;
            double pricePerKm = DayOrNight == "day" ? 0.79 : 0.90;
            return startFee + Kilometers * pricePerKm;
        }

        public double BusPrice()
        {
            if (Kilometers < 20) return double.MaxValue;
            return Kilometers * 0.09;
        }

        public double TrainPrice()
        {
            if (Kilometers < 100) return double.MaxValue;
            return Kilometers * 0.06;
        }

        public double GetCheapestTransport()
        {
            double taxi = TaxiPrice();
            double bus = BusPrice();
            double train = TrainPrice();

            return Math.Min(taxi, Math.Min(bus, train));
        }
    }
}
