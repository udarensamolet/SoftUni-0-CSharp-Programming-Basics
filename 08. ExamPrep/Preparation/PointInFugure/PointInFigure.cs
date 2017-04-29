using System;

namespace PointInFugure
{
    class PointInFigure
    {
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int x1 = 4;
            int x2 = 10;
            int x3 = 12;
            int x4 = 2;

            int y1 = 3;
            int y2 = 1;
            int y3 = -3;
            int y4 = -5;

            if ((x >= x1 && x <= x2 && y <= y1 && y >= y2) || (x >= x2 && x <= x3 && y <= y2 && y >= y3) || (x >= x1 && x <= x2 && y >= y4 && y <= y3) || (x >= x4 && x <= x1 && y >= y3 && y <= y2) || (x >= x1 && x <= x2 && y <= y2 && y >= y3))
            {
                Console.WriteLine("in");
            }

            else
            {
                Console.WriteLine("out");
            }
        }
    }
}
