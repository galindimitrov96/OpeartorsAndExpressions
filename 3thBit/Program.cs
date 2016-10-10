using System;

namespace _3thBit
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = 3;
            Console.WriteLine("Enter number");
            int n = int.Parse(Console.ReadLine());
            int mask = 1 << p;
            int nAndMask = n & mask;
            int bit = nAndMask >> p;
            Console.WriteLine(bit);
        }
    }
}
