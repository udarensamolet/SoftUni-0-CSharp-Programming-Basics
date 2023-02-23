using System;

namespace ChristmasTree
{
    class ChristmasTree
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            //top
            Console.Write(new string(' ', n+1));
            Console.WriteLine("|");

            //the other part
            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string(' ', n-row));
                Console.Write(new string('*', row));
                Console.Write(" | ");
                Console.Write(new string('*', row));
                Console.WriteLine();
            }
        }
    }
}
