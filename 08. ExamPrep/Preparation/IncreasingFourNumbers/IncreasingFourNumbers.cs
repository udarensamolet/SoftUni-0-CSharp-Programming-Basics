using System;

namespace IncreasingFourNumbers
{
    class IncreasingFourNumbers
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (b - a < 3)
            {
                Console.WriteLine("No");
            }

            else
            {
                for (int i = a; i <= b - 3; i++)
                {
                    for (int j = a + 1; j <= b - 2; j++)
                    {
                        for (int k = a + 2; k <= b - 1; k++)
                        {
                            for (int l = a + 3; l <= b; l++)
                            {
                                if (l > k && k > j && j > i)
                                {
                                    Console.WriteLine("{0} {1} {2} {3}", i, j, k, l);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
