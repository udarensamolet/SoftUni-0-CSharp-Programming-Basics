using System;

namespace Rocket
{
    class Rocket
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            //top
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', n + (n - 1) / 2 - i));
                Console.Write("/");
                Console.Write(new string(' ', i * 2));
                Console.Write("\\");
                Console.Write(new string('.', n + (n - 1) / 2 - i));
                Console.WriteLine();
            }

            //row
            Console.Write(new string('.', n / 2));
            Console.Write(new string('*', n * 2));
            Console.Write(new string('.', n / 2));
            Console.WriteLine();

            //middle
            for (int i = 0; i < n * 2; i++)
            {
                Console.Write(new string('.', n / 2));
                Console.Write("|");
                Console.Write(new string('\\', n * 2 - 2));
                Console.Write("|");
                Console.Write(new string('.', n / 2));
                Console.WriteLine();
            }

            //bottom
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('.', n / 2 - i));
                Console.Write("/");
                Console.Write(new string('*', n * 2 - 2 + 2 * i));
                Console.Write("\\");
                Console.Write(new string('.', n / 2 - i));
                Console.WriteLine();
            }
        }
    }
}
