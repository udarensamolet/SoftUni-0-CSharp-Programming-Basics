using System;

namespace Harvest
{
    class Harvest
    {
        static void Main()
        {
            double squareM = double.Parse(Console.ReadLine());
            double grapeOneSquare = double.Parse(Console.ReadLine());
            double neededLiters = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());

            double harvest = squareM * grapeOneSquare;
            double harvestWine = harvest * 0.4 / 2.5;

            if (harvestWine < neededLiters)
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(neededLiters - harvestWine));
            }
            else
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(harvestWine));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(harvestWine - neededLiters), Math.Ceiling((harvestWine - neededLiters) / workers));
            }
        }
    }
}
