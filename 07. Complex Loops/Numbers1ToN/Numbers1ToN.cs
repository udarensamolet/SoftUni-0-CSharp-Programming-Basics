﻿using System;


namespace Numbers1ToN
{
    class Numbers1ToN
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = n; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
