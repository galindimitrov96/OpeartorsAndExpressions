﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            number = int.Parse(Console.ReadLine());
            if ((number % 2) == 0)
            {
                Console.WriteLine("The number {0} is even", number);
            }
            else
            {
                Console.WriteLine("The number {0} is odd.", number);
            }
        }
    }
}
