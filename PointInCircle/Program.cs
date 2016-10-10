using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("X =");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("y =");
            float y = float.Parse(Console.ReadLine());
            bool isInside = (x * x) + (y * y) <= (2 * 2);
            Console.WriteLine("These coordinates are inside the circle = " + isInside);

        }
    }
}
