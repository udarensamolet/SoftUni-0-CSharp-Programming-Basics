using System;

namespace LeftAndRightSum
{
    class LeftAndRightSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < n; i++)
            {
                int left = int.Parse(Console.ReadLine());
                sum1 += left;
            }

            for (int i = 0; i < n; i++)
            {
                int right = int.Parse(Console.ReadLine());
                sum2 += right;
            }

            if (sum1 - sum2 == 0)
            {
                Console.WriteLine("Yes, sum = {0}", sum1);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(sum1 - sum2));
            }
        }
    }
}
