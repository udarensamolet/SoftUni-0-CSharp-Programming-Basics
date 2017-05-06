using System;

namespace CarToGo
{
    class CarToGo
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            double price = 0;
            string carType = null;
            string carClass = null;

            if (budget <= 100)
            {
                carClass = "Economy class";
                if (season == "summer")
                {
                    carType = "Cabrio";
                    price = budget * 35 / 100;
                }
                else if (season == "winter")
                {
                    carType = "Jeep";
                    price = budget * 65 / 100;
                }
            }

            else if (budget > 100 && budget <= 500)
            {
                carClass = "Compact class";
                if (season == "summer")
                {
                    carType = "Cabrio";
                    price = budget * 45 / 100;
                }
                else if (season == "winter")
                {
                    carType = "Jeep";
                    price = budget * 80 / 100;
                }
            }

            else if (budget > 500)
            {
                carClass = "Luxury class";
                carType = "Jeep";
                price = budget * 90 / 100;
            }

            Console.WriteLine("{0}", carClass);
            Console.WriteLine("{0} - {1:f2}", carType, price);
        }
    }
}
