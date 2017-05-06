using System;

namespace SumOfTwoNumbers
{
    class SumOfTwoNumbers
    {
        static void Main()
        {
            double start = double.Parse(Console.ReadLine());
            double end = double.Parse(Console.ReadLine());
            double magicNumber = double.Parse(Console.ReadLine());

            int counter = 0;

            for (double i = start; i <= end; i++)
            {
                for (double j = start; j <= end; j++)
                {
                    counter++;
                    if (i + j == magicNumber)
                    {
                        Console.WriteLine("Combination N:{0} ({1} + {2} = {3})", counter, i, j, magicNumber);
                        return;
                    }
                }
            }

            Console.WriteLine("{0} combinations - neither equals {1}", counter, magicNumber);
        }
    }
}
