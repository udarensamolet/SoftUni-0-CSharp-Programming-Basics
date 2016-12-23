using System;

namespace Histogram
{
    class Histogram
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (input < 200)
                {
                    p1++;
                }
                else if (input >= 200 && input < 400)
                {
                    p2++;
                }
                else if (input >= 400 && input < 600)
                {
                    p3++;
                }
                else if (input >= 600 & input < 800)
                {
                    p4++;
                }
                else if (input >= 800)
                {
                    p5++;
                }
            }

            Console.WriteLine("{0:f2} %", (p1 * 100) / n );
            Console.WriteLine("{0:f2} %", (p2 * 100) / n );
            Console.WriteLine("{0:f2} %", (p3 * 100) / n );
            Console.WriteLine("{0:f2} %", (p4 * 100) / n );
            Console.WriteLine("{0:f2} %", (p5 * 100) / n );
        }
    }
}
