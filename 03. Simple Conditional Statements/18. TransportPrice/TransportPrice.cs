using System;


namespace _18.TransportPrice
{
    class TransportPrice
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string time = Console.ReadLine();

            double taxi = 0;
            double bus = 0;
            double train = 0;

            if (n < 20)
            {
                if (time == "day")
                {
                    Console.WriteLine((n * 0.79) + 0.70);
                }
                else if (time == "night")
                {
                    Console.WriteLine((n * 0.90) + 0.70);
                }
            }

            else if (n >= 20 && n < 100)
            {
                if (time == "day")
                {
                    taxi = (n * 0.79) + 0.70;
                    bus = n * 0.09;

                    if (taxi < bus)
                    {
                        Console.WriteLine(taxi);
                    }
                    else
                    {
                        Console.WriteLine(bus);
                    }
                }
                else if (time == "night")
                {
                    taxi = (n * 0.90) + 0.90;
                    bus = n * 0.09;

                    if (taxi < bus)
                    {
                        Console.WriteLine(taxi);
                    }
                    else
                    {
                        Console.WriteLine(bus);
                    }
                }
            }

            else if (n >= 100)
            {
                if (time == "day")
                {
                    taxi = (n * 0.79) + 0.70;
                    bus = n * 0.09;
                    train = n * 0.06;

                    if (taxi < bus)
                    {
                        if (taxi < train)
                        {
                            Console.WriteLine(taxi);
                        }
                        else
                        {
                            Console.WriteLine(train);
                        }
                    }
                    else
                    {
                        if (bus < train)
                        {
                            Console.WriteLine(bus);
                        }
                        else
                        {
                            Console.WriteLine(train);
                        }
                    }
                }
                else if (time == "night")
                {
                    taxi = (n * 0.90) + 0.70;
                    bus = n * 0.09;
                    train = n * 0.06;

                    if (taxi < bus)
                    {
                        if (taxi < train)
                        {
                            Console.WriteLine(taxi);
                        }
                        else
                        {
                            Console.WriteLine(train);
                        }
                    }
                    else
                    {
                        if (bus < train)
                        {
                            Console.WriteLine(bus);
                        }
                        else
                        {
                            Console.WriteLine(train);
                        }
                    }
                }
            }
        }
    }
}
