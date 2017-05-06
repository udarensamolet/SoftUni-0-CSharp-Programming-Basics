using System;

namespace Diamond
{
    class Diamond
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            //top row
            Console.Write(new string('.', n));
            Console.Write(new string('*', n * 3));
            Console.Write(new string('.', n));
            Console.WriteLine();


            //upper middle
            for (int i = 0; i < n - 1 ; i++)
            {
                Console.Write(new string('.', n - i - 1));
                Console.Write("*");
                Console.Write(new string('.', 3 * n + 2 * i));
                Console.Write("*");
                Console.Write(new string('.', n - i - 1));
                Console.WriteLine();
            }

            //middle row
            Console.Write(new string('*', 5 * n));
            Console.WriteLine();

            //bottom middle
            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write(new string('.', i + 1));
                Console.Write("*");
                Console.Write(new string('.', 5 * n - 4 - 2 * i));
                Console.Write("*");
                Console.Write(new string('.', i + 1));
                Console.WriteLine();
            }

            //bottom row
            Console.Write(new string('.', 2 * n + 1));
            Console.Write(new string('*', n - 2));
            Console.Write(new string('.', 2 * n + 1));
            Console.WriteLine();
        }
    }
}
