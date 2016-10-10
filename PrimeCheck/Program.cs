using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Enter positive integer number <=100");
            int num = int.Parse(Console.ReadLine());
            if (num <= 1)
            {
                Console.WriteLine("This integer is NOT a prime number!");
            }
            else if (num > 1 && num <= 100) 
            {
                if (num == 2 || num == 3 || num == 5 || num == 7) 
                {
                    Console.WriteLine("This integer IS prime number!");
                }
                else
                {
                    if (num % 2 != 0 && num % 3 != 0 && num % 5 != 0 && num % 7 != 0) 
                    {
                        Console.WriteLine("This integer is a prime number!");
                    }
                    else
                    {
                        Console.WriteLine("This integer is NOT a prime number!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter an integer which is in range!");
            }
        }
    }
}