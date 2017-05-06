using System;

namespace OnTimeForExam
{
    class OnTimeForTheExam
    {
        static void Main()
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minExam = int.Parse(Console.ReadLine());
            int hourArr = int.Parse(Console.ReadLine());
            int minArr = int.Parse(Console.ReadLine());

            int timeExam = hourExam * 60 + minExam;
            int timeArr = hourArr * 60 + minArr;

            if (timeExam - timeArr > 30)
            {
                Console.WriteLine("Early");
                if (timeExam - timeArr < 60)
                {
                    Console.WriteLine("{0} minutes before the start", timeExam - timeArr);
                }
                else if (timeExam - timeArr >= 60)
                {
                    if ((timeExam - timeArr) % 60 < 10)
                    {
                        Console.WriteLine("{0}:0{1} hours before the start", (timeExam - timeArr) / 60, (timeExam - timeArr) % 60);
                    }
                    else
                    {
                        Console.WriteLine("{0}:{1} hours before the start", (timeExam - timeArr) / 60, (timeExam - timeArr) % 60);
                    }
                }
            }

            else if (timeExam - timeArr >= 0 && timeExam - timeArr <= 30)
            {
                Console.WriteLine("On time");
                if (timeExam - timeArr > 0 && timeExam - timeArr <= 30)
                {
                    Console.WriteLine("{0} minutes before the start", timeExam - timeArr);
                }
            }

            else
            {
                Console.WriteLine("Late");
                if (timeArr - timeExam < 60)
                {
                    Console.WriteLine("{0} minutes after the start", timeArr - timeExam);
                }
                else if (timeArr - timeExam >= 60)
                {
                    if ((timeArr - timeExam) % 60 < 10)
                    {
                        Console.WriteLine("{0}:0{1} hours after the start", (timeArr - timeExam) / 60, (timeArr - timeExam) % 60);
                    }
                    else
                    {
                        Console.WriteLine("{0}:{1} hours after the start", (timeArr - timeExam) / 60, (timeArr - timeExam) % 60);
                    }
                }
            }
        }
    }
}
