using System;

namespace OddEvenPosition
{
    class OddEvenPosition
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());

            double evenSum = 0;
            double evenMax = Double.MinValue;
            double evenMin = Double.MaxValue;

            double oddSum = 0;
            double oddMax = Double.MinValue;
            double oddMin = Double.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                double input = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += input;

                    if (input > evenMax)
                    {
                        evenMax = input;
                    }

                    if (input < evenMin)
                    {
                        evenMin = input;
                    }
                }
                else
                {
                    oddSum += input;

                    if (input > oddMax)
                    {
                        oddMax = input;
                    }

                    if (input < oddMin)
                    {
                        oddMin = input;
                    }
                }
            }

            if (n == 0)
            {
                Console.WriteLine("OddSum = 0,");
                Console.WriteLine("OddMin = No,");
                Console.WriteLine("OddMax = No,");
                Console.WriteLine("EvenSum = 0,");
                Console.WriteLine("EvenMin = No,");
                Console.WriteLine("EvenMax = No");
            }

            else if (n == 1)
            {
                Console.WriteLine("OddSum = {0},", oddSum);
                Console.WriteLine("OddMin = {0},", oddMin);
                Console.WriteLine("OddMax = {0},", oddMax);
                Console.WriteLine("EvenSum = 0,");
                Console.WriteLine("EvenMin = No,");
                Console.WriteLine("EvenMax = No");
            }

            else
            {
                Console.WriteLine("OddSum = {0},", oddSum);
                Console.WriteLine("OddMin = {0},", oddMin);
                Console.WriteLine("OddMax = {0},", oddMax);
                Console.WriteLine("EvenSum = {0},", evenSum);
                Console.WriteLine("EvenMin = {0},", evenMin);
                Console.WriteLine("EvenMax = {0}", evenMax);
            }
        }
    }
}
