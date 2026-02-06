using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace control_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 50, c = 60;
            if (a > b && a > c)
                Console.WriteLine("a is grater than b");
            else if (b>c)
                Console.WriteLine("b is greater than c");
                Console.WriteLine("c is greater than a");
                Console.Read();
           


                
        }
    }
}
