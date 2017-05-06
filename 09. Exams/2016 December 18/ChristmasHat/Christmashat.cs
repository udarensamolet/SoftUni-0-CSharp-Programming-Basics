using System;

namespace ChristmasHat
{
    class ChristmasHat
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            //first top row
            Console.Write(new string('.', n * 2 - 1));
            Console.Write("/|\\");
            Console.Write(new string('.', n * 2 - 1));
            Console.WriteLine();

            //second top row
            Console.Write(new string('.', n * 2 - 1));
            Console.Write("\\|/");
            Console.Write(new string('.', n * 2 - 1));
            Console.WriteLine();


            //middle
            for (int i = 0; i < n * 2; i++)
            {
                Console.Write(new string('.', n * 2 - 1 - i));
                Console.Write("*");
                Console.Write(new string('-', i));
                Console.Write("*");
                Console.Write(new string('-', i));
                Console.Write("*");
                Console.Write(new string('.', n * 2 - 1 - i));
                Console.WriteLine();
            }


            //bottom
            Console.WriteLine(new string('*', n * 4 + 1));
            for (int i = 0; i < n * 4 + 1; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
            Console.WriteLine(new string('*', n * 4 + 1));



        }
    }
}
