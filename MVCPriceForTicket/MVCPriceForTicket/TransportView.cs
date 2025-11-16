using System;
using System.Collections.Generic;
using System.Text;

namespace MVCPriceForTicket
{
    public class TransportView
    {
        public int ReadKilometers()
        {
            Console.Write("Enter kilometers: ");
            return int.Parse(Console.ReadLine());
        }

        public string ReadDayOrNight()
        {
            Console.Write("Enter period (day/night): ");
            return Console.ReadLine();
        }

        public void ShowResult(double price)
        {
            Console.WriteLine(Math.Round(price, 2));
        }
    }
}
