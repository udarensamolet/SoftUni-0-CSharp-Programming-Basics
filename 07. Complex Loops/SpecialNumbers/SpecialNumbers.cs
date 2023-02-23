using System;

namespace SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int ones = 0;
            int tens = 0;
            int hundreds = 0;
            int thousands = 0;
           

            for (int i = 1111; i <= 9999; i++)
            {
                ones = i % 10;
                tens = (i / 10) % 10;
                hundreds = (i / 100) % 10;
                thousands = (i / 1000) % 10;

                if (ones != 0 && tens != 0 && hundreds != 0 && thousands != 0)
                {
                    if (n % ones == 0 && n % tens == 0 && n % hundreds == 0 && n % thousands == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
    }
}
