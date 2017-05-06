using System;

namespace TorrentPirate
{
    class TorrentPirate
    {
        static void Main()
        {
            double d = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());

            double downloadTime = d / 2 / 60 / 60;
            double priceDownloading = downloadTime * w;
            double moviesDownloaded = d / 1500;
            double cinemaPrice = moviesDownloaded * p;

            if (priceDownloading <= cinemaPrice)
            {
                Console.WriteLine("mall -> {0:f2}lv", priceDownloading);
            }
            else
            {
                Console.WriteLine("cinema -> {0:f2}lv", cinemaPrice);
            }
        }
    }
}
