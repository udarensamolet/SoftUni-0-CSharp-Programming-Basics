﻿using System;

namespace AnimalType
{
    class AnimalType
    {
        static void Main()
        {
            string animal = Console.ReadLine();

            switch (animal)
            {
                case "dog": Console.WriteLine("mammal"); break;
                case "crocodile": Console.WriteLine("reptile"); break;
                case "tortoise": Console.WriteLine("reptile"); break;
                case "snake": Console.WriteLine("reptile"); break;
                default: Console.WriteLine("unknown"); break;
            }
        }
    }
}
