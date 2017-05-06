using System;

namespace Vacation
{
    class Vacation
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            string location = null;
            string stay = null;
            double price = 0;

            if (budget <= 1000)
            {
                stay = "Camp";

                if (season == "summer")
                {
                    location = "Alaska";
                    price = budget * 65 / 100;
                }
                else if (season == "winter")
                {
                    location = "Morocco";
                    price = budget * 45 / 100;
                }
            }

            else if (budget > 1000 && budget <= 3000)
            {
                stay = "Hut";

                if (season == "summer")
                {
                    location = "Alaska";
                    price = budget * 80 / 100;
                }
                else if (season == "winter")
                {
                    location = "Morocco";
                    price = budget * 60 / 100;
                }
            }

            else if (budget > 3000)
            {
                stay = "Hotel";
                price = budget * 90 / 100; 


                if (season == "summer")
                {
                    location = "Alaska";
                    
                }
                else if (season == "winter")
                {
                    location = "Morocco";
                }
            }

            Console.WriteLine("{0} - {1} - {2:f2}", location, stay, price);
        }
    }
}
