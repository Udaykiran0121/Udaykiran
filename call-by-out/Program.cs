using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace call_by_out
{
    class myclass
    {
        internal void nothing(int number, out int multiple)

        {
            multiple = number * 10;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            int result;

            myclass obj = new myclass();
            obj.nothing(5, out result);
            Console.WriteLine("the number value is :" + number);
            Console.WriteLine("return modify value is :" + result);



        }
    }
}
