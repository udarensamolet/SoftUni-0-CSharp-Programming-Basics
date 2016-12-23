using System;

namespace CelsiusToFarenheit
{
    class CelsiusToFarenheit
    {
        static void Main()
        {
            double c = double.Parse(Console.ReadLine());

            double f = c * 9 / 5 + 32;

            Console.WriteLine(Math.Round(f, 2));
        }
    }
}
