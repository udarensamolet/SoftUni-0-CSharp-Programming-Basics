using System;

namespace Journey
{
    class Journey
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            if (budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if (season == "summer")
                {
                    Console.WriteLine("Camp - {0:f2}", Math.Round((budget * 0.30), 2));
                }
                else if (season == "winter")
                {
                    Console.WriteLine("Hotel - {0:f2}", Math.Round((budget * 0.70), 2));
                }
            }

            else if (budget > 100 && budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (season == "summer")
                {
                    Console.WriteLine("Camp - {0:f2}", Math.Round((budget * 0.40), 2));
                }
                else if (season == "winter")
                {
                    Console.WriteLine("Hotel - {0:f2}", Math.Round((budget * 0.80), 2));
                }
            }

            else if (budget > 1000)
            {
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - {0:f2}", Math.Round((budget * 0.90), 2));
            }
        }
    }
}
