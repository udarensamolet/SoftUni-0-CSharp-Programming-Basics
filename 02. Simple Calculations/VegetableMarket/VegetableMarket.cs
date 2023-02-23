using System;

namespace VegetableMarket
{
    class VegetableMarket
    {
        static void Main()
        {
            double priceVeg = double.Parse(Console.ReadLine());
            double priceFruit = double.Parse(Console.ReadLine());
            double kgVeg = double.Parse(Console.ReadLine());
            double kgFruit = double.Parse(Console.ReadLine());

            Console.WriteLine((((kgVeg * priceVeg) + (kgFruit * priceFruit))/1.94));
        }
    }
}
