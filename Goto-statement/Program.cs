using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goto_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10, j = 20;
            if (i < j)



                goto label;
            label:
            Console.WriteLine("this is Sung jin-woo");
            Console.Read();
        }

           


        
    }
}
