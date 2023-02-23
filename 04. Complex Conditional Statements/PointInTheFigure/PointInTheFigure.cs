using System;

namespace PointInTheFigure
{
    class PointInTheFigure
    {
        static void Main()
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int x1 = 0;
            int y1 = 0;
            int x2 = 3 * h;
            int y2 = h;
            int x3 = 2 * h;
            int y3 = 4 * h; 
            int x4 = h;

            if (x > x1 && x < x2 && y > y1 && y < y2 || x > x4 && x < x3 & y > y2 && y < y3)
            {
                if (y == y2 && x >= x4 && x <= x4)
                {
                    Console.WriteLine("inside");
                }
                Console.WriteLine("inside");
            }

            else if (((x == x1 || x == x2) && y >= y1 && y <= y2) || (y == y1 || y == y2) && x >= x1 && x <= x2)
            {
                if (y == y2 && x > x4 && x < x3)
                {
                    Console.WriteLine("inside");
                }
                else
                {
                    Console.WriteLine("border");
                }
            }

            else if (((x == x4 || x == x3) && y >= y2 && y <= y3) || ((y == y2 || y == y3) && x >= x4 && x <= x3))
            {
                if (y == y2 && x > x4 && x < x3)
                {
                    Console.WriteLine("inside");
                }
                else
                {
                    Console.WriteLine("border");
                }
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
