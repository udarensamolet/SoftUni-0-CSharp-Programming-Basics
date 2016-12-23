using System;

namespace Butterfly
{
    class Butterfly
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            //top
            for (int row = 0; row < n - 2; row++)
            {
                if (row % 2 != 0)
                {
                    Console.Write(new string('-', n - 2));
                    Console.Write("\\ /");
                    Console.Write(new string('-', n - 2));
                }
                else
                {
                    Console.Write(new string('*', n - 2));
                    Console.Write("\\ /");
                    Console.Write(new string('*', n - 2));
                }
                Console.WriteLine();
            }

            //middle
            Console.Write(new string(' ', n - 1));
            Console.Write("@");
            Console.WriteLine();

            //bottom
            for (int row = 0; row < n - 2; row++)
            {
                if (row % 2 != 0)
                {
                    Console.Write(new string('-', n - 2));
                    Console.Write("/ \\");
                    Console.Write(new string('-', n - 2));
                }
                else
                {
                    Console.Write(new string('*', n - 2));
                    Console.Write("/ \\");
                    Console.Write(new string('*', n - 2));
                }
                Console.WriteLine();
            }
        }
    }
}
