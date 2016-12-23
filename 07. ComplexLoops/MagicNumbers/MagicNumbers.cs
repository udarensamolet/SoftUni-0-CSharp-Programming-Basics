using System;

namespace MagicNumbers
{
    class MagicNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int ones = 0;
            int tens = 0;
            int hundreds = 0;
            int thousands = 0;
            int tenthousands = 0;
            int hundredthousands = 0;

            for (int i = 100000; i <= 999999; i++)
            {
                ones = i % 10;
                tens = (i / 10) % 10;
                hundreds = (i / 100) % 10;
                thousands = (i / 1000) % 10;
                tenthousands = (i / 10000) % 10;
                hundredthousands = (i / 100000) % 10;

                if (ones * tens * hundreds * thousands * tenthousands * hundredthousands == n)
                {
                    Console.Write(i + " ");
                } 
            }
        }
    }
}
