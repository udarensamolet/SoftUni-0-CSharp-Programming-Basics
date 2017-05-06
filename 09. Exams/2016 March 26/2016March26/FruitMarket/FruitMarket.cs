using System;

namespace FruitMarket
{
    class FruitMarket
    {
        static void Main()
        {
            double vegetablePrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            double vegetanleQuantity = double.Parse(Console.ReadLine());
            double fruitQuantity = double.Parse(Console.ReadLine());

            Console.WriteLine((vegetablePrice * vegetanleQuantity + fruitPrice * fruitQuantity) / 1.94);
        }
    }
}
