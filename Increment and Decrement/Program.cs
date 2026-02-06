using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increment_and_Decrement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Increment and Decrement operators in C#");
            Console.WriteLine("Enter a Number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" before incrment of a is :" + a);
            Console.WriteLine("pre- increment of a is :{0}", ++a);
            Console.WriteLine("after increment of a is :{0}", a);

            Console.WriteLine("decrement opertors in c#");
            Console.WriteLine("Enter a number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("before decrement of b is:" + b);
            Console.WriteLine("pre-decrement of b is:{0}", --b);
            Console.WriteLine("after decrement of b is :{0}", b);
        }







                ;
        }
    }
}
