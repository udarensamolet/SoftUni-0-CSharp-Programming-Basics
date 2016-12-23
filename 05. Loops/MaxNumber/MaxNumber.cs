using System;

namespace MaxNumber
{
    class MaxNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int max = Int32.MinValue;

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (input > max)
                {
                    max = input;
                }
            }
            Console.WriteLine(max);
        }
    }
}
