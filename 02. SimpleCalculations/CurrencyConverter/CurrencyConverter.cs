using System;

namespace USDToBGN
{
    class USDToBGN
    {
        static void Main()
        {
            double amount = double.Parse(Console.ReadLine());
            string curIn = Console.ReadLine();
            string curOut = Console.ReadLine();

            switch (curIn)
            {
                case "USD":
                    switch (curOut)
                    {
                        case "EUR":
                            Console.WriteLine(Math.Round((amount * 0.904690822), 2));
                            break;
                        case "BGN":
                            Console.WriteLine(Math.Round((amount * 1.77139132), 2));
                            break;
                    }
                    break;
                case "EUR":
                    switch (curOut)
                    {
                        case "USD":
                            Console.WriteLine(Math.Round((amount * 1.10535), 2));
                            break;
                        case "BGN":
                            Console.WriteLine(Math.Round((amount * 1.95583), 2));
                            break;
                    }
                    break;
                case "BGN":
                    switch (curOut)
                    {
                        case "USD":
                            Console.WriteLine(Math.Round((amount * 0.564528), 2));
                            break;
                        case "EUR":
                            Console.WriteLine(Math.Round((amount * 0.511292), 2));
                            break;
                    }
                    break;
            }
        }
    }
}
