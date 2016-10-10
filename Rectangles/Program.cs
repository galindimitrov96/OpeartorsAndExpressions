using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter width of rectangle:");
            float width = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter height of rectangle:");
            float height = float.Parse(Console.ReadLine());
            float rectanglesArea = width * height;
            Console.WriteLine("Rectangle area is {0}",rectanglesArea);
            float rectanglePerimeter = width * 2 + height * 2;
            Console.WriteLine("rectangles perimeter is {0}", rectanglePerimeter);
            
        }
    }
}
