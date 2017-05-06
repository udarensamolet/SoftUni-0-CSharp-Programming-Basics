using System;

namespace StupidPasswordGenerator
{
    class StupidPasswordGenerator
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            char letter = 'a';

            if (l == 1) letter = 'a';
            if (l == 2) letter = 'b';
            if (l == 3) letter = 'c';
            if (l == 4) letter = 'd';
            if (l == 5) letter = 'e';
            if (l == 6) letter = 'f';
            if (l == 7) letter = 'g';
            if (l == 8) letter = 'h';
            if (l == 9) letter = 'i';
            if (l == 10) letter = 'j';
            if (l == 11) letter = 'k';
            if (l == 12) letter = 'l';
            if (l == 13) letter = 'm';
            if (l == 14) letter = 'n';
            if (l == 15) letter = 'o';
            if (l == 16) letter = 'p';
            if (l == 17) letter = 'q';
            if (l == 18) letter = 'r';
            if (l == 19) letter = 's';
            if (l == 20) letter = 't';
            if (l == 21) letter = 'u';
            if (l == 22) letter = 'v';
            if (l == 23) letter = 'w';
            if (l == 24) letter = 'x';
            if (l == 25) letter = 'y';
            if (l == 26) letter = 'z';

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    for (char k = 'a'; k <= letter; k++)
                    {
                       for (char m = 'a'; m <= letter; m++)
                        {
                            for (int o = 1; o <= n; o++)
                            {
                                if (o > i && o > j)
                                {
                                    Console.Write("{0}{1}{2}{3}{4} ", i, j, k, m, o);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
