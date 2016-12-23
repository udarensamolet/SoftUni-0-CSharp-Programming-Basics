using System;

namespace PrimeCheck
{
    class PrimeCheck
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            bool prime = true;

            if (n < 2)
            {
                prime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i != 0)
                    {
                        prime = true;
                    }
                    else
                    {
                        prime = false;
                        break;
                    }
                    //break;
                }
            }
            //Console.WriteLine(prime);

            if (prime == true)
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }
        }
    }
}
