using System;

namespace FallenInLove
{
    class FallenInLove
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            //top
            for (int i = 0; i < n; i++)
            {
                Console.Write("#");
                Console.Write(new string('~', i));
                Console.Write("#");
                Console.Write(new string('.', 2 * (n - i)));
                Console.Write("#");
                Console.Write(new string('.', i * 2));
                Console.Write("#");
                Console.Write(new string('.', 2 * (n - i)));
                Console.Write("#");
                Console.Write(new string('~', i));
                Console.Write("#");
                Console.WriteLine();
            }

            //middle
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', 1 + (2 * i)));
                Console.Write("#");
                Console.Write(new string('~', n - i));
                Console.Write("#");
                Console.Write(new string('.', 2 * (n - i)));
                Console.Write("#");
                Console.Write(new string('~', n - i));
                Console.Write("#");
                Console.Write(new string('.', 1 + (2 * i)));
                Console.WriteLine();
            }

            //before bottom row
            Console.Write(new string('.', (2 * n) + 1));
            Console.Write("####");
            Console.Write(new string('.', (2 * n) + 1));
            Console.WriteLine();

            //bottom row
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', (2 * n) + 2));
                Console.Write("##");
                Console.Write(new string('.', (2 * n) + 2));
                Console.WriteLine();
            }
        }
    }
}
