using System;

namespace SumsStep3Second
{
    class SumsStep3Second
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;

            string input = null;

            for (int i = 0; i < n; i++)
            {
                input += Console.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(input[i]);
            }

            for (int i = 0; i < input.Length; i += 3)
            {
                sum1 = sum1 + (input[i] - 48);
            }

            for (int i = 1; i < input.Length; i += 3)
            {
                sum2 = sum2 + (input[i] - 48);
            }

            for (int i = 2; i < input.Length; i += 3)
            {
                sum3 = sum3 + (input[i] - 48);
            }

            Console.WriteLine("sum1 = {0}", sum1);
            Console.WriteLine("sum2 = {0}", sum2);
            Console.WriteLine("sum3 = {0}", sum3);

        }
    }
}
