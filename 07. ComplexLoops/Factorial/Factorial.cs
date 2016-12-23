using System;

namespace Factorial
{
    class Factorial
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int fact = 1;

            for (int i = 1; i <= n; i++)
            {
                fact = i * fact;
            }

            Console.WriteLine(fact);
        }
    }
}
