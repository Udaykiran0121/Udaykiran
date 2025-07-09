
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Arthimetic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
           Console.WriteLine("addition value is:{0}" , (a + b));
            Console.WriteLine  ("subtraction value is:{0}" , (a - b));
            Console.WriteLine("mutiplication value is:{0}" , (a * b));
            Console.WriteLine("modulus value is:{0}", (a % b));
            Console.WriteLine("divion value is :{0}" , (a / b));
            Console.WriteLine("increment value is:{0}" , (++a));
            Console.WriteLine("decrement value is:{0}", (--b));



        }
    }
}
