using System;

namespace SumSeconds
{
    class SumSeconds
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int sum = a + b + c;

            if (sum <= 59)
            {
                if (sum >= 0 && sum <= 9)
                {
                    Console.WriteLine("0:0{0}", sum);
                }
                else
                {
                    Console.WriteLine("0:{0}", sum);
                }
            }
            else if (sum >= 60 && sum <= 119)
            {
                if (sum - 60 >= 0 && sum - 60 <= 9)
                {
                    Console.WriteLine("1:0{0}", sum - 60);
                }
                else
                {
                    Console.WriteLine("1:{0}", sum - 60);
                }
            }
            else if (sum >= 120 && sum <= 179)
            {
                if (sum - 120 >= 0 && sum - 120 <= 9)
                {
                    Console.WriteLine("2:0{0}", sum - 120);
                }
                else
                {
                    Console.WriteLine("2:{0}", sum - 120);
                }
            }
        }
    }
}
