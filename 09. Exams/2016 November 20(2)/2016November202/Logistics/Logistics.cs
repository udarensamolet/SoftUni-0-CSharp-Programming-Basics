using System;

namespace Logistics
{
    class Logistics
    {
        static void Main()
        {
            double countLoads = double.Parse(Console.ReadLine());
            double tonageLoadsAll = 0;
            double priceLoads = 0;
            double counter1 = 0;
            double counter2 = 0;
            double counter3 = 0;

            for (int i = 0; i < countLoads; i++)
            {
                double tonageLoad = double.Parse(Console.ReadLine());
                tonageLoadsAll += tonageLoad;

                if (tonageLoad <= 3)
                {
                    priceLoads = tonageLoad * 200 + priceLoads;
                    counter1 += tonageLoad;
                }
                else if (tonageLoad >= 4 && tonageLoad <= 11)
                {
                    priceLoads = tonageLoad * 175 + priceLoads;
                    counter2 += tonageLoad;
                }
                else if (tonageLoad >= 12)
                {
                    priceLoads = tonageLoad * 120 + priceLoads;
                    counter3 += tonageLoad;
                }

            }

            Console.WriteLine("{0:f2}", priceLoads / tonageLoadsAll);
            Console.WriteLine("{0:f2}%", counter1 / tonageLoadsAll * 100);
            Console.WriteLine("{0:f2}%", counter2 / tonageLoadsAll * 100);
            Console.WriteLine("{0:f2}%", counter3 / tonageLoadsAll * 100);
        }
    }
}
