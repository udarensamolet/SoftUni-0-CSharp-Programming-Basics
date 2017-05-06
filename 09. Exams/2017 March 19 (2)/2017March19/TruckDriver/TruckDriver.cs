using System;

namespace TruckDriver
{
    class TruckDriver
    {
        static void Main()
        {
            string season = Console.ReadLine().ToLower();
            double kmForMonth = double.Parse(Console.ReadLine());

            double priceKm = kmForMonth;

            if (season == "spring" || season == "autumn")
            {
                if (kmForMonth <= 5000)
                {
                    priceKm *= 0.75;
                }
                else if (kmForMonth > 5000 && kmForMonth <= 10000)
                {
                    priceKm *= 0.95;
                }
                else
                {
                    priceKm *= 1.45;
                }
            }
            else if (season == "summer")
            {
                if (kmForMonth <= 5000)
                {
                    priceKm *= 0.90;
                }
                else if (kmForMonth > 5000 && kmForMonth <= 10000)
                {
                    priceKm *= 1.10;
                }
                else
                {
                    priceKm *= 1.45;
                }
            }
            else
            {
                if (kmForMonth <= 5000)
                {
                    priceKm *= 1.05;
                }
                else if (kmForMonth > 5000 && kmForMonth <= 10000)
                {
                    priceKm *= 1.25;
                }
                else
                {
                    priceKm *= 1.45;
                }
            }

            double money = priceKm * 4 * 0.90;

            Console.WriteLine($"{money:0.00}");
        }
    }
}
