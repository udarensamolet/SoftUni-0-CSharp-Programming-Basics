using System;
using System.Numerics;

namespace HungryGarfield
{
    class HungryGarfield
    {
        static void Main()
        {
            decimal moneyLeftDollars = decimal.Parse(Console.ReadLine());
            decimal exchangeRate = decimal.Parse(Console.ReadLine());
            decimal pizzaPrice = decimal.Parse(Console.ReadLine());
            decimal lasagnaPrice = decimal.Parse(Console.ReadLine());
            decimal sandwichPrice = decimal.Parse(Console.ReadLine());
            decimal pizzaQuantity = decimal.Parse(Console.ReadLine());
            decimal lasagnaQuantity = decimal.Parse(Console.ReadLine());
            decimal sandwichQuantity = decimal.Parse(Console.ReadLine());

            decimal priceEatAllTheFood = pizzaPrice * pizzaQuantity + lasagnaPrice * lasagnaQuantity + sandwichPrice * sandwichQuantity;

            if (priceEatAllTheFood / exchangeRate <= moneyLeftDollars)
            {
                Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:f2}.", moneyLeftDollars - (priceEatAllTheFood / exchangeRate));
            }
            else
            {
                Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:f2}.", (priceEatAllTheFood / exchangeRate) - moneyLeftDollars);
            }
        }
    }
}
