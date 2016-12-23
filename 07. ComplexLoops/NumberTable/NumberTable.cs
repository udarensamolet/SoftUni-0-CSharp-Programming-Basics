using System;

namespace NumberTable
{
    class NumberTable
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    if (rows + cols + 1 > n)
                    {
                        Console.Write("{0} ", 2 * n - (rows + cols + 1));
                    }
                    else
                    {
                        Console.Write("{0} ", rows + cols + 1);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
