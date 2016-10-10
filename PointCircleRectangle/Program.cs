using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointCircleRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter X:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y:");
            double y = double.Parse(Console.ReadLine());
            if ((x - 1) * (x - 1) + (y - 1) * (y - 1) <= 1.5 * 1.5)
            {
                Console.WriteLine("Inside the circle");
            } 
            else
            {
                Console.WriteLine("is outside of the circle");
            }
            if ((x >= -1 && x <= 5) && (y <= 1 && y >= -1))
            {
                Console.WriteLine("and inside the rectangle");
            }
            else
            {
                Console.WriteLine("and outside the rectangle");
            }
        }
    }
}
