using System;

namespace EqualPairs
{
    class EqualPairs
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double sumNow = 0;
            double diff = 0;
            double sumLast = 0;
            double max = double.MinValue;

            for (int i = 0; i < n; i++)
            {
                sumLast = sumNow;
                sumNow = 0;

                for (int j = 0; j <= 1; j++)
                {
                    double input = double.Parse(Console.ReadLine());
                    sumNow += input;
                }

                if (i != 0)
                {
                    diff = Math.Abs(sumNow - sumLast);

                    if (diff > max)
                    {
                        max = diff;
                    }
                }
            }

            if (max == double.MinValue)
            {
                Console.WriteLine("Yes, value = {0}", sumNow);
            }

            else if (max == 0)
            {
                Console.WriteLine("Yes, value = {0}", sumNow);
            }
            else
            {
                Console.WriteLine("No, maxdiff = {0}", max);
            }
        }
    }
}
