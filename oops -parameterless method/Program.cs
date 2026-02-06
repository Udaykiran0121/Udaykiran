using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops__parameterless_method
{
    internal class Program
    {
        class myclass
        {
            internal void square()
            {
                int a = 5;
                int b = a * a;
                Console.WriteLine("square of a number is :" + b);
            }
            internal void cube()
            {
                int a = 5;
                int b = a * a * a;
                Console.WriteLine("cube of a number is :" + b);
            }

        }
        static void Main(string[] args)
        {
            myclass none = new myclass();
            none.square();
            none.cube();

        }
    }
}
