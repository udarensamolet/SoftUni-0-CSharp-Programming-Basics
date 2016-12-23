using System;

namespace HalfSumElement
{
    class HalfSumElement
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int max = Int32.MinValue;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (input > max)
                {
                    max = input;
                }

                sum += input;
            }

            if (sum - max == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", max);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs(max - (sum - max)));
            }
        }
    }
}
