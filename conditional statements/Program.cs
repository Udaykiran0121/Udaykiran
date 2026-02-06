using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditional_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 10)
            {
                Console.WriteLine("you are selected");
            }
            else 
            {
                Console.WriteLine("you are disqualified");
               

            }
        }
    }
}
