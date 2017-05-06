using System;

namespace MatchTickets
{
    class MatchTickets
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine().ToLower();
            int people = int.Parse(Console.ReadLine());

            double transport = 0;

            if (people >= 1 && people <= 4)
            {
                transport = budget * 0.75;
            }
            else if (people >= 5 && people <= 9)
            {
                transport = budget * 0.60;
            }
            else if (people >= 10 && people <= 24)
            {
                transport = budget * 0.50;
            }
            else if (people >= 25 && people <= 49)
            {
                transport = budget * 0.40;
            }
            else if (people >= 50)
            {
                transport = budget * 0.25;
            }

            if (category == "vip")
            {
                if (budget - transport >= people * 499.99)
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", budget - transport - people * 499.99);
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", people * 499.99 - (budget - transport));
                }
            }
            else if (category == "normal")
            {
                if (budget - transport >= people * 249.99)
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", budget - transport - people * 249.99);
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", people * 249.99 - (budget - transport));
                }
            }

        }
    }
}
