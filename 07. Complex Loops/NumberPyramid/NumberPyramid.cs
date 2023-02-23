using System;

namespace NumberPyramid
{
    class NumberPyramid
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 1;

            for (int row = 0; row <= n; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    Console.Write("{0} ", counter);
                    counter++;

                    if (counter > n)
                    {
                        break;
                    }
                }
                if (counter > n)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
