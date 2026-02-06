using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace realational_operator
{
    /*Realtional operator :-
     * >finds the reation between two numbers and resultant will be in boolean form.
     * example: >,>=,<,<=,*,*=,/,?=,==,!=
     * 
     */ 
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 20;
            Console.WriteLine("a>b is {0}",a>b);
            Console.WriteLine("a>=b is {0}",a >= b);
            Console.WriteLine("a<b is {0}", a < b);
            Console.WriteLine("a<=b is {0}", a <= b);
            Console.WriteLine("a==b is {0}", a == b);
            Console.WriteLine("a*=b is {0}", a *= b);
            Console.WriteLine("a*b is {0}", a * b);
            Console.WriteLine("a/b is {0}", a / b);
            Console.WriteLine("a/=b is {0}", a /= b);
            Console.WriteLine("a!=b is {0}", a != b);
        }
    }
}
