using System;


namespace OnTimeForExam
{
    class OnTimeForExam
    {
        static void Main()
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minExam = int.Parse(Console.ReadLine());
            int hourArr = int.Parse(Console.ReadLine());
            int minArr = int.Parse(Console.ReadLine());

            int timeExam = hourExam * 60 + minExam;
            int timeArr = hourArr * 60 + minArr;
            int timeDiff = timeExam - timeArr;

            if (timeExam == timeArr)
            {
                Console.WriteLine("On time");
            }
            else if (timeDiff <= 30 && timeDiff > 0)
            {
                Console.WriteLine("On time");
                Console.WriteLine("{0} minutes before the start", timeDiff);
            }

            else if (timeDiff > 30 && timeDiff < 60)
            {
                Console.WriteLine("Early");
                Console.WriteLine("{0} minutes before the start", timeDiff);
            }

            else if (timeDiff == 60)
            {
                Console.WriteLine("Early");
                Console.WriteLine("{0}:00 hours before the start", timeDiff / 60);
            }

            else if (timeDiff > 60)
            {
                Console.WriteLine("Early");
                if (timeDiff - (60 * (timeDiff / 60)) < 10)
                {
                    Console.WriteLine("{0}:0{1} hours before the start", timeDiff / 60, timeDiff - (60 * (timeDiff / 60)));
                }
                else
                {
                    Console.WriteLine("{0}:{1} hours before the start", timeDiff / 60, timeDiff - (60 * (timeDiff / 60)));
                }
            }

            else if (timeDiff < 0 && timeDiff > -60)
            {
                Console.WriteLine("Late");
                Console.WriteLine("{0} minutes after the start", Math.Abs(timeDiff));
            }

            else if (timeDiff == -60)
            {
                Console.WriteLine("Late");
                Console.WriteLine("1:00 hours after the start");
            }

            else if (timeDiff < -60)
            {
                int timeDiffAbs = Math.Abs(timeDiff);
                Console.WriteLine("Late");
                if (timeDiffAbs - (60 * (timeDiffAbs / 60)) < 10)
                {
                    Console.WriteLine("{0}:0{1} hours after the start", timeDiffAbs / 60, timeDiffAbs - (60 * (timeDiffAbs / 60)));
                }
                else
                {
                    Console.WriteLine("{0}:{1} hours after the start", timeDiffAbs / 60, timeDiffAbs - (60 * (timeDiffAbs / 60)));
                }
            }
        }
    }
}
