using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameterized_method
{
    internal class Program
    {
        internal class dotnet
        {
            internal void square(int a)
            {
                int b = a * a;
                Console.WriteLine("the square of b is :{0}", b);
            }
            internal void cube (int a)
            {
                int c = a * a * a;
                Console.WriteLine("the cube of c is :{0}", c);
            }

        }
        static void Main(string[] args)
        {
            dotnet naveen = new dotnet();
            Console.WriteLine("Enter a number :");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(" please enter a value:");
            int y = int.Parse(Console.ReadLine());
            naveen.square(x);
            naveen.cube(y);
        }
    }
}
