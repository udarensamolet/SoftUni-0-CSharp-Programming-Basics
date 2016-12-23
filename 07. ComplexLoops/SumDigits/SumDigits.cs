using System;

namespace SumDigits
{
    class SumDigits
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            int quotient = 0;

            while (num != 0)
            {
                quotient = num % 10;
                num = num / 10;
                sum += quotient;
            }

            Console.WriteLine(sum);
        }
    }
}
