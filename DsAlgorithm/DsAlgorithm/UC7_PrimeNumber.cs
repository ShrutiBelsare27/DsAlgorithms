﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class UC7_PrimeNumber
    {
        public static void Prime()
        {
            int i = 0;
            Console.WriteLine("Welcome to Prime umber Program  \n\nPrime Number Between 0-1000 are->");
            Console.Write("2 3 5 7 ");
            for (i = 2; i <= 1000; i++)
            {
                {
                    if (i % 2 == 0 || i % 3 == 0 || i % 5 == 0 || i % 7 == 0)
                    { }
                    else
                        Console.Write(i + " ");
                }
            }
        }
    }
}