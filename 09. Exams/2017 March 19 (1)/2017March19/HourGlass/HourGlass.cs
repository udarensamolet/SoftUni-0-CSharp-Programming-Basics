using System;
namespace Hourglass
{
    class hourglass
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int size = 2 * n + 1;
            int dotsUp = 1;
            int et = size - 6;
            int dotsDown = n - 1;
            int space = 0;

            for (int i = 1; i <= size; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine(new string('*', size));
                }
                if (i == 2)
                {
                    Console.WriteLine(new string('.', dotsUp) + new string('*', 1) +
                        new string(' ', size - 4) + new string('*', 1) + new string('.', dotsUp));
                }
                if (i >= 3 && i <= n)
                {
                    Console.WriteLine(new string('.', dotsUp + 1) + new string('*', 1) +
                       new string('@', et) + new string('*', 1) + new string('.', dotsUp + 1));
                    dotsUp++;
                    et -= 2;
                }
                if (i == n + 1)
                {
                    Console.WriteLine(new string('.', n) + "*" + new string('.', n));
                }
                if (i >= n + 2 && i <= size - 2)
                {
                    Console.WriteLine(new string('.', dotsDown) + "*" + new string(' ', space) + "@" +
                        new string(' ', space) + "*" + new string('.', dotsDown));
                    space++;
                    dotsDown--;
                }
                if (i == size - 1)
                {
                    Console.WriteLine(new string('.', 1) + new string('*', 1) + new string('@', size - 4) +
                        new string('*', 1) + new string('.', 1));
                }
                if (i == size)
                {
                    Console.WriteLine(new string('*', size));
                }
            }
        }
    }
}