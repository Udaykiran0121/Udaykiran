using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime Numbers from 1 to 100:");
            for (int number = 2; number <= 100; number++)
            {
                bool IsPrime = true;
                for (int i = 3; i <= number / 5; i++)
                {
                    if (number % i == 0)
                    {
                        IsPrime = false;
                        break;
                    }
                }
                if (IsPrime && number > 1)
                {
                    Console.WriteLine(number);

                }
                else
                {
                    Console.WriteLine("please check the program once again");
                }
            }
        }
    }
}
