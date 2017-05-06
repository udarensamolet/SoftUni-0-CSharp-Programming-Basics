using System;

namespace Histogram
{
    class Histogram
    {
        static void Main()
        {
            double n = int.Parse(Console.ReadLine());
                
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
                else if (input >= 200 && input <= 399)
                {
                    p2++;
                }
                else if (input >= 400 && input <= 599)
                {
                    p3++;
                }
                else if (input >= 600 && input <= 799)
                {
                    p4++;
                }
                else if (input >= 800)
                {
                    p5++;
                }
             }
            Console.WriteLine("{0:f2}%", (p1 / n) * 100);
            Console.WriteLine("{0:f2}%", (p2 / n) * 100);
            Console.WriteLine("{0:f2}%", (p3 / n) * 100);
            Console.WriteLine("{0:f2}%", (p4 / n) * 100);
            Console.WriteLine("{0:f2}%", (p5 / n) * 100);
        }
    }
}
