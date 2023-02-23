using System;

namespace TubesInPool
{
    class TubesInPool
    {
        static void Main()
        {
            double v = double.Parse(Console.ReadLine());
            double p1 = double.Parse(Console.ReadLine());
            double p2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double debit1 = p1 * h;
            double debit2 = p2 * h;

            if (debit1 + debit2 < v)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", Math.Floor(((debit1 + debit2) / v) * 100), Math.Floor((debit1 / (debit1 + debit2)) * 100), Math.Floor(debit2 / (debit1 + debit2) * 100));
            }
            else if (debit1 + debit2 > v)
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", h, Math.Round(((debit1 + debit2) - v), 2));
            }
            else if (debit1 + debit2 == v)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", Math.Floor(((debit1 + debit2) / v) * 100), Math.Floor((debit1 / (debit1 + debit2)) * 100), Math.Floor(debit2 / (debit1 + debit2) * 100));
            }
        }
    }
}
