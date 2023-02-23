using System;

namespace Volleyball
{
    class Volleyball
    {
        static void Main()
        {
            string year = Console.ReadLine();
            double p = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double plays = (p * 2 / 3) + ((48 - h) * 3 / 4) + h;

            if (year == "leap")
            {
                Console.WriteLine("{0}", Math.Floor(plays + (plays * 0.15)));
            }
            else
            {
                Console.WriteLine("{0}", Math.Floor(plays));
            }
        }
    }
}
