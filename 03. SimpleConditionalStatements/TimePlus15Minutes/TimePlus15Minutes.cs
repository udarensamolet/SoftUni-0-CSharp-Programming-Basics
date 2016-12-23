using System;

namespace TimePlus15Minutes
{
    class TimePlus15Minutes
    {
        static void Main()
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            if (min + 15 >= 60)
            {
                if (min + 15 - 60 >= 0 && min + 15 - 60 <= 9)
                {
                    if (hour + 1 == 24)
                    {
                        Console.WriteLine("{0}:0{1}", 0, min + 15 - 60);
                    }
                    else
                    {
                        Console.WriteLine("{0}:0{1}", hour + 1, min + 15 - 60);
                    }
                }
                else
                {
                    if (hour + 1 == 24)
                    {
                        Console.WriteLine("{0}:{1}", 0, min + 15 - 60);
                    }
                    else
                    {
                        Console.WriteLine("{0}:{1}", hour + 1, min + 15 - 60);
                    }
                }
            }
            else
            {
                Console.WriteLine("{0}:{1}", hour, min + 15);              
            }          
        }
    }
}
