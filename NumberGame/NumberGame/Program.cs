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
            string input;
            int guess, low = 0, high = 100, c;
            while (true)
            {
                guess =  (high + low) / 2;
                Console.WriteLine("Is {0} your number? (h, l, c)", guess);
                input = Console.ReadLine();
                if (input == "l")
                {
                    high = guess - 1;
                }
                if (input == "h")
                {
                    low = guess + 1;
                }
                if (input == "c")
                {
                    break;
                }
                
            }
        }
    }
}

