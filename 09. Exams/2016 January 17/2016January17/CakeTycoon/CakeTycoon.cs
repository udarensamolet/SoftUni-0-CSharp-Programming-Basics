using System;
using System.Numerics;

namespace CakeTycoon
{
    class CakeTycoon
    {
        static void Main()
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());
            int t = int.Parse(Console.ReadLine());
            double p = int.Parse(Console.ReadLine());

            if ((double)n * c > f)
            {
                Console.WriteLine("Can make only {0} cakes, need {1:f2} kg more flour", Math.Floor(f / c), (((double)n * c) - f), 2);
            }

            else if ((double)n * c <= f)
            {
                Console.WriteLine("All products available, price of a cake: {0:f2}", (t * p) / (double)n * 1.25);
            }
        }
    }
}
