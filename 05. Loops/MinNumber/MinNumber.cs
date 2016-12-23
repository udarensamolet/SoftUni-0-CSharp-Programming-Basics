using System;

namespace MinNumber
{
    class MinNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int min = Int32.MaxValue;

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (input < min)
                {
                    min = input;
                }
            }
            Console.WriteLine(min);
        }
    }
}
