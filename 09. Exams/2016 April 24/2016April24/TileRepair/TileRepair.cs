using System;

namespace TileRepair
{
    class TileRepair
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double o = double.Parse(Console.ReadLine());

            double neededTiles = (Math.Pow(n, 2) - (m * o)) / (w * l);
            double neededTime = neededTiles * 0.2;

            Console.WriteLine(neededTiles);
            Console.WriteLine(neededTime);

        }
    }
}
