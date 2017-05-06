using System;

namespace Stop
{
    class Stop
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            //top row
            Console.Write(new string('.', n + 1));
            Console.Write(new string('_', n * 2 + 1));
            Console.Write(new string('.', n + 1));
            Console.WriteLine();
            
            //upper middle
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', n - i));
                Console.Write("//");
                Console.Write(new string('_', (n + i) * 2 - 1));
                Console.Write("\\"+"\\");
                Console.Write(new string('.', n - i));
                Console.WriteLine();
            }

            //middle
            Console.Write("//");
            Console.Write(new string('_', 2 * n - 3));
            Console.Write("STOP!");
            Console.Write(new string('_', 2 * n - 3));
            Console.Write("\\" + "\\");
            Console.WriteLine();

            //bottom
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(new string('.', n - i - 1));
                Console.Write("\\" + "\\");
                Console.Write(new string('_', (n + i) * 2 + 1));
                Console.Write("//");
                Console.Write(new string('.', n - i - 1));
                Console.WriteLine();
            }
        }
    }
}
