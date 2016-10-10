using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivadeBy7And5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int numberInput = int.Parse(Console.ReadLine());
            bool boolNumber = (numberInput % 7 == 0) && (numberInput % 5 == 0);
            if (boolNumber == true)         
            {
                Console.WriteLine("the {0} is true", numberInput);
            }
            else
            {
                Console.WriteLine("The {0} is false", numberInput);
            }

        }
    }
}
