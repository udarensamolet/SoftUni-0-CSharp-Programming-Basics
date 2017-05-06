using System;

namespace Fox
{
    class Fox
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            //ears
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('*', i + 1));
                Console.Write("\\");
                Console.Write(new string('-', 2 * n - 2 * i - 1));
                Console.Write("/");
                Console.Write(new string('*', i + 1));
                Console.WriteLine();
            }

            //eyes
            for (int i = 0; i < n / 3; i++)
            {
                Console.Write("|");
                Console.Write(new string('*', n / 2 + i));
                Console.Write("\\");
                Console.Write(new string('*', n - 2 * i));
                Console.Write("/");
                Console.Write(new string('*', n / 2 + i));
                Console.Write("|");
                Console.WriteLine();
            }




            //mucuna
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('-', i + 1));
                Console.Write("\\");
                Console.Write(new string('*', 2 * n - 2 * i - 1));
                Console.Write("/");
                Console.Write(new string('-', i + 1));
                Console.WriteLine();
            }
        }
    }
}
