using System;

namespace IlluminatiLock
{
    class IlluminatiLock
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            //top row

            Console.Write(new string('.', n));
            Console.Write(new string('#', n));
            Console.Write(new string('.', n));
            Console.WriteLine();

            //top middle 
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('.', n - (2 * i) - 2));
                Console.Write("##");
                Console.Write(new string('.', i * 2));
                Console.Write("#");
                Console.Write(new string('.', n - 2));
                Console.Write("#");
                Console.Write(new string('.', i * 2));
                Console.Write("##");
                Console.Write(new string('.', n - (2 * i) - 2));
                Console.WriteLine();
            }

            //middle bottom
            for (int i = (n / 2) - 1; i >= 0; i--)
            {
                Console.Write(new string('.', n - (2 * i) - 2));
                Console.Write("##");
                Console.Write(new string('.', i * 2));
                Console.Write("#");
                Console.Write(new string('.', n - 2));
                Console.Write("#");
                Console.Write(new string('.', i * 2));
                Console.Write("##");
                Console.Write(new string('.', n - (2 * i) - 2));
                Console.WriteLine();
            }

            //bottom row
            Console.Write(new string('.', n));
            Console.Write(new string('#', n));
            Console.Write(new string('.', n));
            Console.WriteLine();
        }
    }
}
