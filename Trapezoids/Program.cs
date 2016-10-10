using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoids
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter first side \"a\"");
            double firstSide = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second side \"b\"");
            double secondSide = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height \"h\"");
            double heighSide = double.Parse(Console.ReadLine());
            double trapezoidArea = ((firstSide + secondSide) /2) * heighSide;
            Console.WriteLine("Trapezoid's area is: {0}", trapezoidArea);

        }
    }
}
