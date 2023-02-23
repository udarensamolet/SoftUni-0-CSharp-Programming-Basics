using System;

namespace BonusScore
{
    class BonusScore
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double bonusScore;

            if (n <= 100)
            {
                bonusScore = 5;
            }
            else if (n >= 100 && n <= 1000)
            {
                bonusScore = n * 0.20;
            }
            else
            {
                bonusScore = n * 0.10;
            }

            if (n % 2 == 0)
            {
                bonusScore += 1;
            }

            if ((n % 10) / 5 == 1)
            {
                bonusScore += 2;
            }

            Console.WriteLine(bonusScore);
            Console.WriteLine(n + bonusScore);
        }
    }
}
