using System;

namespace DivisionWithoutRemainder
{
    class DivisionWithoutRemainder
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;

            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());

                if (input % 2 == 0)
                {
                    p1++;
                }
                if (input % 3 == 0)
                {
                    p2++;
                }
                if (input % 4 == 0)
                {
                    p3++;
                }
            }

            Console.WriteLine("{0:f2}%", p1 / n * 100);
            Console.WriteLine("{0:f2}%", p2 / n * 100);
            Console.WriteLine("{0:f2}%", p3 / n * 100);
        }
    }
}
