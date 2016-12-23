using System;

namespace DrawFort
{
    class DrawFort
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            //top
            Console.Write("/");
            Console.Write(new string('^', n / 2));
            Console.Write("\\");
            if (n > 4)
            {
                Console.Write(new string('_', (2 * n) - 4 - (2 * (n / 2))));
            }
            Console.Write("/");
            Console.Write(new string('^', n / 2));
            Console.Write("\\");
            Console.WriteLine();


            //middle
            for (int row = 0; row < n - 2; row++)
            {
                Console.Write("|");

                if (row == n - 3)
                {
                    if (n > 4)
                    {
                        Console.Write(new string(' ', ((2 * n) - ((2 * n) - 4 - (2 * (n / 2))) - 2) / 2));
                        Console.Write(new string('_', (2 * n) - 4 - (2 * (n / 2))));
                        Console.Write(new string(' ', ((2 * n) - ((2 * n) - 4 - (2 * (n / 2))) - 2) / 2));
                    }
                    else
                    {
                        Console.Write(new string(' ', (2 * n) - 2));
                    }
                }

                else
                {
                    Console.Write(new string(' ', (2 * n) - 2));
                }
                Console.Write("|");
                Console.WriteLine();
            }

            //bottom      .
            Console.Write("\\");
            Console.Write(new string('_', n / 2));
            Console.Write("/");

            if (n > 4)
            {
                Console.Write(new string(' ', (2 * n) - 4 - (2 * (n / 2))));
            }
            Console.Write("\\");
            Console.Write(new string('_', n / 2));
            Console.Write("/");
            Console.WriteLine();
        }
    }
}
