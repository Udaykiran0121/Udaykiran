using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace increment_and_decrement_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("value of a is :" + a);
            Console.WriteLine("pre increment value is {0}", ++a);
            Console.WriteLine("post increment value is {0}", a++);
            
           

        }
    }
}
