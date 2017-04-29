using System;

namespace DateAfter5Days
{
    class DateAfter5Days
    {
        static void Main()
        {
            int d = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int newD = d + 5;
            int newM = m + 1;

            switch (m)
            {
                case 1:             //jan 31
                case 3:             // mar 31
                case 5:             // may 31
                case 7:             // jul 31
                case 8:             // aug 31
                case 10:            // oct 31
                    if (newD > 31)
                    {
                        if (newM > 9) // ok
                        {
                            Console.WriteLine("{0}.{1}", newD - 31, newM);
                        }
                        else // ok
                        {
                            Console.WriteLine("{0}.0{1}", newD - 31, newM);
                        }

                    }
                    else // ok
                    {
                        if (m > 9) // ok
                        {
                            Console.WriteLine("{0}.{1}", newD, m);
                        }
                        else // ok
                        {
                            Console.WriteLine("{0}.0{1}", newD, m);
                        }
                    }
                    break;

                case 2:    // ok         // feb 28
                    if (newD > 28)  // ok
                    {
                        Console.WriteLine("{0}.0{1}", newD - 28, newM);
                    }
                    else  // ok
                    {
                        Console.WriteLine("{0}.0{1}", newD, m);
                    }
                    break;

                case 4:             // apr 30
                case 6:             // jun 30
                case 9:             // sep 30
                case 11:            // nov 30
                    if (newD > 30)
                    {
                        if (newM > 9)
                        {
                            Console.WriteLine("{0}.{1}", newD - 30, newM);
                        }
                        else
                        {
                            Console.WriteLine("{0}.0{1}", newD - 30, newM);
                        }
                    }
                    else
                    {
                        if (newM > 9)
                        {
                            Console.WriteLine("{0}.{1}", newD, m);
                        }
                        else
                        {
                            Console.WriteLine("{0}.0{1}", newD, m);
                        }
                    }
                    break;

                case 12:            // dec 31
                    if (newD > 31)
                    {
                        m = 1;
                        Console.WriteLine("{0}.0{1}", newD - 31, m);
                    }
                    else
                    {
                        Console.WriteLine("{0}.{1}", newD, m);
                    }
                    break;
            } 
        }
    }
}
