using System;

namespace TwoNumbersSum
{
    class twoNumbersSum
    {
        static void Main()
        {
            int startCount = int.Parse(Console.ReadLine());
            int endCount = int.Parse(Console.ReadLine());
            int twoNumbersSum = int.Parse(Console.ReadLine());

            int counter = 0;
            int numA = 0;
            int numB = 0;

            for (int a = startCount; a >= endCount; a--)
            {
                for (int b = startCount; b >= endCount; b--)
                {
                    counter++;
                    numB = b;
                    if (a + b == twoNumbersSum)
                    {
                        break;
                    }
                }
                numA = a;
                if (numA + numB == twoNumbersSum)
                {
                    break;
                }
            }
            if (numA + numB == twoNumbersSum)
            {
                Console.WriteLine($"Combination N:{counter} ({numA} + {numB} = {twoNumbersSum})");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {twoNumbersSum}");
            }
        }
    }
}