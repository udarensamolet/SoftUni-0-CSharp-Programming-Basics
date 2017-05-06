using System;

namespace Battles
{
    class Battles
    {
        static void Main()
        {
            int pokemon1 = int.Parse(Console.ReadLine());
            int pokemon2 = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = 1; i <= pokemon1; i++)
            {
                for (int j = 1; j <= pokemon2; j++)
                {
                    counter++;
                    if (counter > max)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("({0} <-> {1}) ", i, j);
                    }
                }
            }
        }
    }
}
