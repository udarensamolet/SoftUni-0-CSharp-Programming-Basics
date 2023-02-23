using System;

namespace FruitShop
{
    class FruitShop
    {
        static void Main()
        {
            string product = Console.ReadLine();
            string day = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());

            if (day == "sunday" || day == "saturday")
            {
                switch (product)
                {
                    case "banana": Console.WriteLine(Math.Round((quantity * 2.70), 2)); break;
                    case "apple": Console.WriteLine(Math.Round((quantity * 1.25), 2)); break;
                    case "orange": Console.WriteLine(Math.Round((quantity * 0.90), 2)); break;
                    case "grapefruit": Console.WriteLine(Math.Round((quantity * 1.60), 2)); break;
                    case "kiwi": Console.WriteLine(Math.Round((quantity * 3.00), 2)); break;
                    case "pineapple": Console.WriteLine(Math.Round((quantity * 5.60), 2)); break;
                    case "grapes": Console.WriteLine(Math.Round((quantity * 4.20), 2)); break;
                    default: Console.WriteLine("error"); break;
                }
            }
            else if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                switch (product)
                {
                    case "banana": Console.WriteLine(Math.Round((quantity * 2.50), 2)); break;
                    case "apple": Console.WriteLine(Math.Round((quantity * 1.20), 2)); break;
                    case "orange": Console.WriteLine(Math.Round((quantity * 0.85), 2)); break;
                    case "grapefruit": Console.WriteLine(Math.Round((quantity * 1.45), 2)); break;
                    case "kiwi": Console.WriteLine(Math.Round((quantity * 2.70), 2)); break;
                    case "pineapple": Console.WriteLine(Math.Round((quantity * 5.50), 2)); break;
                    case "grapes": Console.WriteLine(Math.Round((quantity * 3.85), 2)); break;
                    default: Console.WriteLine("error"); break;
                }
            }
            else 
            {
                Console.WriteLine("error");
            }
        }
    }
}
