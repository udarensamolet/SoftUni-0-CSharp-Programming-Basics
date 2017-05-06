using System;

namespace BikeRace
{
    class BikeRace
    {
        static void Main()
        {
            double juniors = double.Parse(Console.ReadLine());
            double seniors = double.Parse(Console.ReadLine());
            string track = Console.ReadLine().ToLower();

            double price1 = 0;
            double price2 = 0;
            double price3 = 0;
            double price4 = 0;

            if (track == "trail")
            {
                price1 = juniors * 5.50 + seniors * 7;
            }

            else if (track == "cross-country")
            {
                if (seniors + juniors >= 50)
                {
                    price2 = (juniors * 8 + seniors * 9.50) - 0.25 * (juniors * 8 + seniors * 9.50);
                }
                else
                {
                    price2 = juniors * 8 + seniors * 9.50;
                }
            }

            else if (track == "downhill")
            {
                price3 = juniors * 12.25 + seniors * 13.75;
            }

            else if (track == "road")
            {
                price4 = juniors * 20 + seniors * 21.50;
            }

            double profit = price1 + price2 + price3 + price4 - 0.05 * (price1 + price2 + price3 + price4);

            Console.WriteLine("{0:f2}", profit);
        }
    }
}
