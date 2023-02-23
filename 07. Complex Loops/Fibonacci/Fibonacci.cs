using System;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int fib0 = 1;
            int fib1 = 1;
            int fib = 0;

            for (int i = 1; i < n; i++)
            {
                fib = fib0 + fib1;
                fib0 = fib1;
                fib1 = fib;
            }

            if (n == 0 || n == 1)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine(fib);
            }
        }
    }
}
