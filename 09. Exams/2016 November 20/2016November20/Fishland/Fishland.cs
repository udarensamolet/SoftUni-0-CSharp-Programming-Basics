using System;

namespace Fishland
{
    class Fishland
    {
        static void Main()
        {
            double skumriqPrice = double.Parse(Console.ReadLine());
            double cacaPrice = double.Parse(Console.ReadLine());
            double kgPalamud = double.Parse(Console.ReadLine());
            double kgSafrid = double.Parse(Console.ReadLine());
            double kgMidi = double.Parse(Console.ReadLine());

            double smetkaPalamud = (skumriqPrice * 0.6 + skumriqPrice) * kgPalamud;
            double smetkaSafrid = (cacaPrice * 0.8 + cacaPrice) * kgSafrid;
            double smetkaMidi = kgMidi * 7.50;

            Console.WriteLine("{0:f2}", smetkaPalamud + smetkaSafrid + smetkaMidi);
        }
    }
}
