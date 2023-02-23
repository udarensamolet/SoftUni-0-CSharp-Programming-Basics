using System;

namespace RadiansToDegrees
{
    class RadiansToDegrees
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());

            double d = (r * 180) / Math.PI;

            Console.WriteLine(Math.Round(d, 0));
        }
    }
}
