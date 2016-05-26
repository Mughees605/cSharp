using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Nested if statement  5/4/2016  Today i completed if statements and nested 
             if statement */

            Console.WriteLine("Please enter your number");
            int x = int.Parse(Console.ReadLine());

            if (x == 10)
            {
                Console.WriteLine("\n\n you won a new car");
            }
            else if (x == 2)
            {
                Console.WriteLine("\n\n you won a new bike");

            }
            else 
            {
                Console.WriteLine("you lost try again");
            }
            Console.ReadLine();
        }
    }
}
