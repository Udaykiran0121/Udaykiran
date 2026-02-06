using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameters_types
{
    /*
     * passing parameter  : passing a value to the method is called calling parameter
     * paramter : variable is declared within the method signature is called parameter 
     * -types:
     * 1,formal parameter
     * 2,actual parameter
     * >formal paramter: formal parameter is which calls the function is also known as called funtion
     * >actual paramter: actual paramter is a calling function 
     * 
     */
    internal class Program
    {
        class myclass
        {
            internal void integer(int a,int b)//it is a formal parameter
                                               //and integer is called function.
            {
                int c = a + b;
                Console.WriteLine("value of c is " + c);

            }
        }
        static void Main(string[] args)
        {
            myclass obj = new myclass();
            int x = 10;
            int y = 20;
            obj.integer(x, y);//here x and y are the actual parameters 
                              // integer method is calling function.
            Console.WriteLine("value of x is " + x);
            Console .WriteLine ("value of y is " +y);
           

        }
    }
}
