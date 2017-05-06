using System;

namespace Butterfly
{
    class Butterfly
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            //top
            for (int i = 0; i < n - 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(new string('*', n - 2));
                }
                else
                {
                    Console.Write(new string('-', n - 2));
                }
                Console.Write("\\ /");
                if (i % 2 == 0)
                {
                    Console.Write(new string('*', n - 2));
                }
                else
                {
                    Console.Write(new string('-', n - 2));
                }
                Console.WriteLine();
            }

            //middle
            Console.Write(new string(' ', n - 1));
            Console.Write("@");
            Console.WriteLine();

            //bottom
            for (int i = 0; i < n - 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(new string('*', n - 2));
                }
                else
                {
                    Console.Write(new string('-', n - 2));
                }
                Console.Write("/ \\");
                if (i % 2 == 0)
                {
                    Console.Write(new string('*', n - 2));
                }
                else
                {
                    Console.Write(new string('-', n - 2));
                }
                Console.WriteLine();
            }
        }
    }
}
