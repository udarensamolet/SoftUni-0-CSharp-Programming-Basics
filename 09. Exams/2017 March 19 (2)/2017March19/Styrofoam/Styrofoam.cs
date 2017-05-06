using System;

namespace Styrofoam
{
    class Styrofoam
    {
        static void Main()
        {
            double money = double.Parse(Console.ReadLine());
            double houseArrea = double.Parse(Console.ReadLine());
            double windows = double.Parse(Console.ReadLine());
            double foamM2inPack = double.Parse(Console.ReadLine());
            double foamPrice = double.Parse(Console.ReadLine());

            double winArrea = windows * 2.4;
            double foamNeed = (houseArrea - winArrea) * 1.10;
            double packNeeded = Math.Ceiling(foamNeed / foamM2inPack);
            double endPrice = packNeeded * foamPrice;

            if (money > endPrice)
            {
                Console.WriteLine($"Spent: {endPrice:0.00}");
                Console.WriteLine($"Left: {(money - endPrice):0.00}");
            }
            else
            {
                Console.WriteLine($"Need more: {(endPrice - money):0.00}");
            }
        }
    }
}
