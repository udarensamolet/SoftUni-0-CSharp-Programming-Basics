using System;

namespace MaxCombination
{
    class MaxCombination
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int maxCount = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    counter++;
                    if (counter > maxCount)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("<{0}-{1}>", i, j);
                    }
                }
            }
        }
    }
}
