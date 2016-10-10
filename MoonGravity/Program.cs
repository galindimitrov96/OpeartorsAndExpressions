using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonGravity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Earth weight:");
           float W = float.Parse(Console.ReadLine());
            float WeightOnMoon = (float)0.17 * W;
            Console.WriteLine("Your Moon weight will be: {0}", (double)WeightOnMoon);
        }
    }
}
