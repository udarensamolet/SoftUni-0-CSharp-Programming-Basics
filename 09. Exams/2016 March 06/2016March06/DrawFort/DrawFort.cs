using System;

namespace DrawFort
{
    class DrawFort
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            //upper ok 
            Console.Write("/");
            Console.Write(new string('^', n / 2));
            Console.Write("\\");
            if (n >= 5)
            {
                if (n % 2 == 0)
                {
                    Console.Write(new string('_', n - 4));
                }
                else
                {
                    Console.Write(new string('_', n - 3));
                }
            }
            Console.Write("/");
            Console.Write(new string('^', n / 2));
            Console.Write("\\");
            Console.WriteLine();

            //middle
            for (int i = 0; i < n - 3; i++)
            {
                Console.Write("|");
                if (n >= 5)
                {
                    /*
                    if (n % 2 == 0)
                    {
                        Console.Write(new string(' ', n + 2 + ((n - 1) / 2)));
                    }
                    else
                    {
                        Console.Write(new string(' ', n + 1 + ((n - 1) / 2)));
                    }
                    */
                    Console.Write(new string(' ', 2 * n - 2));
                }
                else
                {
                    Console.Write(new string(' ', n + 2));
                }
                Console.Write("|");
                Console.WriteLine();
            }

            //before last row
            Console.Write("|");
            Console.Write(new string(' ', (2 + n) / 2));
            if (n >= 5)
            {
                if (n % 2 == 0)
                {
                    Console.Write(new string('_', n - 4));
                }
                else
                {
                    Console.Write(new string('_', n - 3));
                }
            }
            Console.Write(new string(' ', (2 + n) / 2));
            Console.Write("|");
            Console.WriteLine();

            //last row
            Console.Write("\\");
            Console.Write(new string('_', n / 2));
            Console.Write("/");
            if (n >= 5)
            {
                if (n % 2 == 0)
                {
                    Console.Write(new string(' ', n - 4));
                }
                else
                {
                    Console.Write(new string(' ', n - 3));
                }
            }
            Console.Write("\\");
            Console.Write(new string('_', n / 2));
            Console.Write("/");
        }
    }
}
