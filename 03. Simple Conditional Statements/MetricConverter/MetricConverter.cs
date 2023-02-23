using System;

namespace MetricConverter
{
    class MetricConverter
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            string metricIn = Console.ReadLine();
            string metricOut = Console.ReadLine();

            switch (metricIn)
            {
                case "m":
                    switch (metricOut)
                    {
                        case "m": Console.WriteLine(n + " m"); break;
                        case "mm": Console.WriteLine(n * 1000 + " mm"); break;
                        case "cm": Console.WriteLine(n * 100 + " cm"); break;
                        case "mi": Console.WriteLine(n * 0.000621371192 + " mi"); break;
                        case "in": Console.WriteLine(n * 39.3700787 + " in"); break;
                        case "km": Console.WriteLine(n * 0.001 + " km"); break;
                        case "ft": Console.WriteLine(n * 3.2808399 + " ft"); break;
                        case "yd": Console.WriteLine(n * 1.0936133 + " yd"); break;
                    }
                    break;
                case "mm":
                    switch (metricOut)
                    {
                        case "m": Console.WriteLine(n * 0.001 + " m"); break;
                        case "mm": Console.WriteLine(n + " mm"); break;
                        case "cm": Console.WriteLine(n * 0.1 + " cm"); break;
                        case "mi": Console.WriteLine(n * 0.001 * 0.000621371192 + " mi"); break;
                        case "in": Console.WriteLine(n * 0.0393700787 + " in"); break;
                        case "km": Console.WriteLine(n * 0.000001 + " cm"); break;
                        case "ft": Console.WriteLine(n * 0.0032808399 + " ft"); break;
                        case "yd": Console.WriteLine(n * 0.0010936133 + " yd"); break;
                    }
                    break;
                case "cm":
                    switch (metricOut)
                    {
                        case "m": Console.WriteLine(n * 0.01 + " m"); break;
                        case "mm": Console.WriteLine(n * 10 + " mm"); break;
                        case "cm": Console.WriteLine(n + " cm"); break;
                        case "mi": Console.WriteLine(n * 0.01 * 0.000621371192 + " mi"); break;
                        case "in": Console.WriteLine(n * 0.393700787 + " in"); break;
                        case "km": Console.WriteLine(n * 0.00001 + " km"); break;
                        case "ft": Console.WriteLine(n * 0.032808399 + " ft"); break;
                        case "yd": Console.WriteLine(n * 0.010936133 + " yd"); break;
                    }
                    break;
                case "mi":
                    switch (metricOut)
                    {
                        case "m": Console.WriteLine(n * 1609.344 + " m"); break;
                        case "mi": Console.WriteLine(n + " mi"); break;
                        case "mm": Console.WriteLine(n * 1609344 + " mm"); break;
                        case "cm": Console.WriteLine(n * 160934.4 + " cm"); break;
                        case "in": Console.WriteLine(n * 63360 + " in"); break;
                        case "km": Console.WriteLine(n * 1.609344 + " km"); break;
                        case "ft": Console.WriteLine(n * 5280 + " ft"); break;
                        case "yd": Console.WriteLine(n * 1760 + " yd"); break;
                    }
                    break;
                case "in":
                    switch (metricOut)
                    {
                        case "m": Console.WriteLine(n * 0.0254 + " m"); break;
                        case "mm": Console.WriteLine(n * 25.4 + " mm"); break;
                        case "cm": Console.WriteLine(n * 2.54 + " cm"); break;
                        case "mi": Console.WriteLine(n * 0.0000157828283 + " mi"); break;
                        case "in": Console.WriteLine(n + " in"); break;
                        case "km": Console.WriteLine(n * 0.0000254 + " km"); break;
                        case "ft": Console.WriteLine(n * 0.0833333333 + " ft"); break;
                        case "yd": Console.WriteLine(n * 0.0277777778 + " yd"); break;
                    }
                    break;
                case "km":
                    switch (metricOut)
                    {
                        case "m": Console.WriteLine(n * 1000 + " m"); break;
                        case "mm": Console.WriteLine(n * 1000000 + " mm"); break;
                        case "cm": Console.WriteLine(n * 100000 + " cm"); break;
                        case "mi": Console.WriteLine(n * 0.621371192 + " mi"); break;
                        case "in": Console.WriteLine(n * 39370.0787 + " in"); break;
                        case "km": Console.WriteLine(n + " km"); break;
                        case "ft": Console.WriteLine(n * 3280.8399 + " ft"); break;
                        case "yd": Console.WriteLine(n * 1093.6133 + " yd"); break;
                    }
                    break;
                case "ft":
                    switch (metricOut)
                    {
                        case "m": Console.WriteLine(n * 0.3048 + " m"); break;
                        case "mm": Console.WriteLine(n * 304.80 + " mm"); break;
                        case "cm": Console.WriteLine(n * 30.48 + " cm"); break;
                        case "mi": Console.WriteLine(n * 0.000189393939 + " mi"); break;
                        case "in": Console.WriteLine(n * 12 + " in"); break;
                        case "km": Console.WriteLine(n * 0.0003048 + " km"); break;
                        case "ft": Console.WriteLine(n + " ft"); break;
                        case "yd": Console.WriteLine(n * 0.333333333 + " yd"); break;
                    }
                    break;
                case "yd":
                    switch (metricOut)
                    {
                        case "m": Console.WriteLine(n * 0.9144 + " m"); break;
                        case "mm": Console.WriteLine(n * 914.4 + " mm"); break;
                        case "cm": Console.WriteLine(n * 91.44 + " cm"); break;
                        case "mi": Console.WriteLine(n * 0.000568181818 + " mi"); break;
                        case "in": Console.WriteLine(n * 36 + " in"); break;
                        case "km": Console.WriteLine(n * 0.0009144 + " km"); break;
                        case "ft": Console.WriteLine(n * 3 + " ft"); break;
                        case "yd": Console.WriteLine(n + " yd"); break;
                    }
                    break;
            }
        }
    }
}
