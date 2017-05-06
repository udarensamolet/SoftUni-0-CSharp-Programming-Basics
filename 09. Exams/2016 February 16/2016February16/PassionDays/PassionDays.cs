using System;

namespace PassionDays
{
    class PassionDays
    {
        static void Main()
        {
            decimal money = decimal.Parse(Console.ReadLine());
            string mall = null;
            string input = null;
            bool stop = true;
            bool secondStop = true;
            int counter = 0;

            while (stop == true)
            {
                mall = Console.ReadLine();

                if (mall != "mall.Enter")
                {
                    stop = true;
                }

                else
                {
                    
                    while (secondStop == true)
                    {
                        input = Console.ReadLine();

                        if (input == "mall.Exit")
                        {
                            secondStop = false;
                            break;
                        }

                        for (int i = 0; i < input.Length; i++)
                        {
                            double value = Convert.ToInt32(input[i]);
                            
                            if(value >= 65 && value <= 90)
                            {
                                value = value - (value * 0.5);
                                if (money > Convert.ToDecimal(value))
                                {
                                    money = money - Convert.ToDecimal(value);
                                    counter++;
                                }
                            }
                            else if (value >= 97 && value <= 122)
                            {
                                value = value - (value * 0.7);
                                if (money > Convert.ToDecimal(value))
                                {
                                    money = money - Convert.ToDecimal(value);
                                    counter++;
                                }
                            }
                            else if (value == 37) //%
                            {
                                if (money != 0)
                                {
                                    money = money / 2;
                                    counter++;
                                }
                            }
                            else if (value == 42) //*
                            {
                                money += 10;
                            }
                            else
                            {
                                if (money >= Convert.ToDecimal(value))
                                {
                                    money = money - Convert.ToDecimal(value);
                                    counter++;
                                }
                            }
                        }
                    }
                    stop = false;
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("No purchases. Money left: {0:f2} lv. ", money);
            }
            else
            {
                Console.WriteLine("{0} purchases. Money left: {1:f2} lv.", counter, money);
            }
        }
    }
}

