using System;

namespace Axe
{
    class Axe
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());


            //top
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('-', n * 3));
                Console.Write("*");
                Console.Write(new string('-', i));
                Console.Write("*");
                Console.Write(new string('-', 2 * n - i - 2));
                Console.WriteLine();
            }

            //middle
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('*', n * 3));
                Console.Write("*");
                Console.Write(new string('-', n - 1));
                Console.Write("*");
                Console.Write(new string('-', n - 1));
                Console.WriteLine();
            }

            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('-', n * 3 - i));
                Console.Write("*");
                if (i == n / 2 - 1)
                {
                    Console.Write(new string('*', n - 1 + 2 * i));
                }
                else
                {
                    Console.Write(new string('-', n - 1 + 2 * i));
                }
                Console.Write("*");
                Console.Write(new string('-', n - 1 - i));
                Console.WriteLine();
            }
        }
    }
}
