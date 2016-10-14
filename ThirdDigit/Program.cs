using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Insert number: ");
            int number = int.Parse(Console.ReadLine());
            if ((number / 100) % 10 == 7)
            {
                Console.WriteLine("The third digit (right-to-left) of number {0} is 7", number);
            }
            else
            {
                Console.WriteLine("The third digit (right-to-left) of number {0} is NOT 7", number);
            }
        }
    }
}

