using System;

namespace GreatestCommonDivisor
{
    class GreatestCommonDivisor
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double remainder = 0;

            while (b != 0)
            {
                remainder = a % b;
                a = b;
                b = remainder;
            }

            Console.WriteLine(a);
        }
    }
}
