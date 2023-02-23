using System;

namespace TradeComissions
{
    class TradeComissions
    {
        static void Main()
        {
            string town = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());

            if (sales >= 0 && sales <= 500)
            {
                switch (town)
                {
                    case "sofia": Console.WriteLine(Math.Round((sales * 0.05), 2)); break;
                    case "varna": Console.WriteLine(Math.Round((sales * 0.045), 2)); break;
                    case "plovdiv": Console.WriteLine(Math.Round((sales * 0.055), 2)); break;
                    default: Console.WriteLine("error"); break;
                }
            }
            else if (sales > 500 && sales <= 1000)
            {
                switch (town)
                {
                    case "sofia": Console.WriteLine(Math.Round((sales * 0.07), 2)); break;
                    case "varna": Console.WriteLine(Math.Round((sales * 0.075), 2)); break;
                    case "plovdiv": Console.WriteLine(Math.Round((sales * 0.08), 2)); break;
                    default: Console.WriteLine("error"); break;
                }
            }
            else if (sales > 1000 && sales <= 10000)
            {
                switch (town)
                {
                    case "sofia": Console.WriteLine(Math.Round((sales * 0.08), 2)); break;
                    case "varna": Console.WriteLine(Math.Round((sales * 0.10), 2)); break;
                    case "plovdiv": Console.WriteLine(Math.Round((sales * 0.12), 2)); break;
                    default: Console.WriteLine("error"); break;
                }
            }
            else if (sales > 10000)
            {
                switch (town)
                {
                    case "sofia": Console.WriteLine(Math.Round((sales * 0.12), 2)); break;
                    case "varna": Console.WriteLine(Math.Round((sales * 0.13), 2)); break;
                    case "plovdiv": Console.WriteLine(Math.Round((sales * 0.145), 2)); break;
                    default: Console.WriteLine("error"); break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
