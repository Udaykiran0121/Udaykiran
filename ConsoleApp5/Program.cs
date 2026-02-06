using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5, fact = 1;
            for (int i=1;i<=x;i++)
            {
                fact *= i;
            }
            Console.WriteLine(fact);
        }
    }
}
