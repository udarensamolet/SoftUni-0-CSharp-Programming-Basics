using System;

namespace SleepyCatTom
{
    class SleepyCatTom
    {
        static void Main()
        {
            int holidays = int.Parse(Console.ReadLine());

            int timeForPlay = (365 - holidays) * 63 + holidays * 127;

            if (timeForPlay > 30000)
            {
                Console.WriteLine("Tom will run away");
                if ((timeForPlay - 30000) % 60 < 10)
                {
                    Console.WriteLine("{0} hours and 0{1} minutes more for play", (timeForPlay - 30000) / 60, (timeForPlay - 30000) % 60);
                }
                else
                {
                    Console.WriteLine("{0} hours and {1} minutes more for play", (timeForPlay - 30000) / 60, (timeForPlay - 30000) % 60);
                }
            }

            else
            {
                Console.WriteLine("Tom sleeps well");
                if ((30000 - timeForPlay % 60) < 10)
                {
                    Console.WriteLine("{0} hours and 0{1} minutes less for play", (30000 - timeForPlay) / 60, (30000 - timeForPlay) % 60);
                }
                else
                {
                    Console.WriteLine("{0} hours and {1} minutes less for play", (30000 - timeForPlay) / 60, (30000 - timeForPlay) % 60);
                }
            }
        }
    }
}
