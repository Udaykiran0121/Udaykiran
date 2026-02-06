using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitwise_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter b number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("and operator is:",a&b);
        }
    }
}
