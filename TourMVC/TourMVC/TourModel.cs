using System;
using System.Collections.Generic;
using System.Text;

namespace TourMVC
{
    public class TravelModel
    {
        public double Budget { get; set; }
        public string Season { get; set; }

        public string Destination { get; set; }
        public string VacationType { get; set; }
        public double MoneySpent { get; set; }

        public void CalculateTrip()
        {
            if (Budget <= 100)
            {
                Destination = "Bulgaria";
                if (Season == "summer")
                {
                    VacationType = "Camp";
                    MoneySpent = Budget * 0.30;
                }
                else
                {
                    VacationType = "Hotel";
                    MoneySpent = Budget * 0.70;
                }
            }
            else if (Budget <= 1000)
            {
                Destination = "Balkans";
                if (Season == "summer")
                {
                    VacationType = "Camp";
                    MoneySpent = Budget * 0.40;
                }
                else
                {
                    VacationType = "Hotel";
                    MoneySpent = Budget * 0.80;
                }
            }
            else
            {
                Destination = "Europe";
                VacationType = "Hotel";
                MoneySpent = Budget * 0.90;
            }
        }
    }
}
