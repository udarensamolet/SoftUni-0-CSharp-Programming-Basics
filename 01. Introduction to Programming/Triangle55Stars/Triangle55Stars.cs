using System;

namespace Triangle55Stars
{
    class Triangle55Stars
    {
        static void Main()
        {
            for (int row = 1; row < 11; row++)
            {
                for (int col = 1; col < row + 1; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
