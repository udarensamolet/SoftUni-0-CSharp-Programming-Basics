using System;

namespace OperationsBetweenNumbers
{
    class OperationsBetweenNumbers
    {
        static void Main()
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string op = Console.ReadLine();

            string oddEven = null;


            switch (op)
            {
                case "+":
                    if ((n1 + n2) % 2 == 0)
                    {
                        oddEven = "even";
                    }
                    else
                    {
                        oddEven = "odd";
                    }
                    Console.WriteLine("{0} + {1} = {2} - {3}", n1, n2, n1 + n2, oddEven);
                    break;

                case "-":
                    if ((n1 - n2) % 2 == 0)
                    {
                        oddEven = "even";
                    }
                    else
                    {
                        oddEven = "odd";
                    }
                    Console.WriteLine("{0} - {1} = {2} - {3}", n1, n2, n1 - n2, oddEven);
                    break;

                case "*":
                    if ((n1 * n2) % 2 == 0)
                    {
                        oddEven = "even";
                    }
                    else
                    {
                        oddEven = "odd";
                    }
                    Console.WriteLine("{0} * {1} = {2} - {3}", n1, n2, n1 * n2, oddEven);
                    break;

                case "/":
                    if (n2 == 0)
                    {
                        Console.WriteLine("Cannot divide {0} by zero", n1);
                    }
                    else
                    {
                        Console.WriteLine("{0} / {1} = {2:f2}", n1, n2, n1 / n2);

                    }
                    break;

                case "%":
                    if (n2 == 0)
                    {
                        Console.WriteLine("Cannot divide {0} by zero", n1);
                    }
                    else
                    {
                        Console.WriteLine("{0} % {1} = {2}", n1, n2, n1 % n2);
                    }
                    break;
            }
        }
    }
}
