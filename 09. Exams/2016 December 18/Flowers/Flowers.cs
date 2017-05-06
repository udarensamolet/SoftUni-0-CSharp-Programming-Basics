using System;

namespace Flowers
{
    class Flowers
    {
        static void Main()
        {
            double hrizantemiCount = double.Parse(Console.ReadLine());
            double roziCount = double.Parse(Console.ReadLine());
            double laletaCount = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string holiday = Console.ReadLine().ToLower();

            /* double hrizantemiPrice = 0;
             double roziPrice = 0;
             double laletaPrice = 0;*/

            double buket = 0;

            if (season == "spring" || season == "summer")
            {
                buket = hrizantemiCount * 2 + roziCount * 4.10 + laletaCount * 2.50;

                if (season == "spring" && laletaCount > 7)
                {
                    buket = buket - buket * 0.05;

                    if (hrizantemiCount + roziCount + laletaCount > 20)
                    {
                        buket = buket - buket * 0.20;
                    }
                }
            }

            else if (season == "autumn" || season == "winter")
            {
                buket = hrizantemiCount * 3.75 + roziCount * 4.50 + laletaCount * 4.15;

                if (season == "winter" && roziCount >= 10)
                {
                    buket = buket - buket * 0.10;

                    if (hrizantemiCount + roziCount + laletaCount > 20)
                    {
                        buket = buket - buket * 0.20;
                    }
                }

                else if (hrizantemiCount + roziCount + laletaCount > 20)
                {
                    buket = buket - buket * 0.20;
                }
            }

            if (holiday == "y")
            {
                buket = buket + buket * 0.15 + 2;
            }
            else
            {
                buket += 2;
            }

            Console.WriteLine("{0:f2}", buket);
        }
    }
}
