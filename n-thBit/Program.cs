using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n_thBit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter position");
            int p = int.Parse(Console.ReadLine());

            int fakeBit = 1 << p;
            int foundBit = n & fakeBit;

            if (foundBit == 0)
            {
                Console.WriteLine("Bit of position {0} is '0'", p);
                Console.WriteLine(Convert.ToString(n , 2).PadLeft(16, '0'));
            }
            else
            {
                Console.WriteLine("Bit of position {0} is '1'", p);
                Console.WriteLine(Convert.ToString(n , 2).PadLeft(16, '0'));
            }
        }
    }
}
