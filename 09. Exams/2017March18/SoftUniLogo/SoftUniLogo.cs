using System;

namespace SoftUniLogo
{
    class SoftUniLogo
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            //top
            int topDots = (12 * n - 6) / 2;
            int topHashTags = 1;
            for (int i = 0; i < n * 2; i++)
            {
                Console.WriteLine(new string('.', topDots) + new string('#', topHashTags) + new string('.', topDots));
                topDots -= 3;
                topHashTags += 6;
            }

            //middle
            int middleDots = 3;
            int middleHashTags = 12 * n - 11;

            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("|" + new string('.', middleDots - 1) + new string('#', middleHashTags) + new string('.', middleDots));
                middleDots += 3;
                middleHashTags -= 6;
            }

            //bottom
            int bottomDots = (12 * n -5 - (6 * n + 1)) / 2;
            int bottomHasHtags = 6 * n + 1;

            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("|" + new string('.', bottomDots - 1) + new string('#', middleHashTags) + new string('.', middleDots));
            }

            //bottomRow
            Console.WriteLine("@" + new string('.', bottomDots - 1) + new string('#', middleHashTags) + new string('.', middleDots));

        }
    }
}
