using System;

namespace ControlNumber
{
    class ControlNumber
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int KontrolNumber = int.Parse(Console.ReadLine());

            int count = 0;
            int sum = 0;
            int endSum = 0;

            for (int a = 1; a <= N; a++)
            {
                for (int b = M; b >= 1; b--)
                {
                    sum = a * 2 + b * 3;
                    endSum += sum;
                    count++;
                    if (endSum >= KontrolNumber)
                    {
                        break;
                    }
                }
                if (endSum >= KontrolNumber)
                {
                    break;
                }
            }
            if (endSum >= KontrolNumber)
            {
                Console.WriteLine("{0} moves", count);
                Console.WriteLine("Score: {0} >= {1}", endSum, KontrolNumber);
            }
            else
            {
                Console.WriteLine("{0} moves", count);
            }
        }
    }
}
