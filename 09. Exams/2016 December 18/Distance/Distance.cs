using System;

namespace Distance
{
    class Distance
    {
        static void Main()
        {
            double firstSpeed = double.Parse(Console.ReadLine());
            double firstTime = double.Parse(Console.ReadLine());
            double secondTime = double.Parse(Console.ReadLine());
            double thirdTime = double.Parse(Console.ReadLine());

            double firstKm = firstSpeed * firstTime / 60;
            double secondSpeed = firstSpeed * 0.10 + firstSpeed;
            double secondKm = secondSpeed * secondTime / 60;
            double thirdSpeed = secondSpeed - secondSpeed * 0.05;
            double thirdKm = thirdSpeed * thirdTime / 60;

            double km = firstKm + secondKm + thirdKm;

            
            Console.WriteLine("{0:f2}", km);
        }
    }
}
