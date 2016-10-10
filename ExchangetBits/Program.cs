﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangetBits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input n: ");
            uint n = uint.Parse(Console.ReadLine());
            Console.WriteLine("Binary representation of n:      {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
            uint firstBits = (n >> 3) & 7;
            uint secondBits = (n >> 24) & 7;
            uint maskFirstBits = 7 << 3;
            uint maskSecondBits = 7 << 24;
            n = n & ~maskFirstBits | (secondBits << 3);
            n = n & ~maskSecondBits | (firstBits << 24);
            Console.WriteLine("Result: {0}", n);
            Console.WriteLine("Binary representation of result: {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
        }
    }
}
