using System;

namespace SumsStep3
{
    class SumsStep3
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;

            double[] input = new double[n];



            for (int i = 0; i < n; i++)
            {
                input[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i += 3)
            {
                sum1 += input[i];
            }

            for (int i = 1; i < n; i += 3)
            {
                sum2 += input[i];
            }

            for (int i = 2; i < n; i += 3)
            {
                sum3 += input[i];
            }

            Console.WriteLine("sum1 = {0}", sum1);
            Console.WriteLine("sum2 = {0}", sum2);
            Console.WriteLine("sum3 = {0}", sum3);
        }
    }
}
