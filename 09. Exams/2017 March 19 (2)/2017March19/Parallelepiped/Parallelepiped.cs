using System;

namespace Parallelepiped
{
    class Parallelepiped
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int collons = 3 * n + 1;
            int rows = 4 * n + 4;
            int startWaves = n - 2;

            int dots = 0;
            int colDots = collons - startWaves - 3;
            int rows1 = rows / 2 - 1;

            Console.WriteLine("+" + new string('~', startWaves) + "+" + new string('.', collons - startWaves - 2));
            for (int i = 1; i <= rows1; i++)
            {
                Console.WriteLine("|" + new string('.', dots) + "\\" +
                    new string('~', startWaves) + "\\" + new string('.', colDots));
                dots++;
                colDots--;
            }

            int dots2 = 1;
            int colDots2 = collons - startWaves - 3;

            Console.WriteLine("\\" + new string('.', colDots2) + "|" +
                                  new string('~', startWaves) + "|");

            for (int i = 1; i <= rows1 - 1; i++)
            {
                Console.WriteLine(new string('.', dots2) + "\\" + new string('.', colDots2 - 1) + "|" +
                                   new string('~', startWaves) + "|");
                dots2++;
                colDots2--;
            }
            Console.WriteLine(new string('.', collons - startWaves - 2) + "+" + new string('~', startWaves) + "+");
        }
    }
}
