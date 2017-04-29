using System;

namespace Bricks
{
    class Bricks
    {
        static void Main()
        {
            double bricks = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());
            double volume = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Ceiling(bricks / workers / volume));
         }
    }
}
