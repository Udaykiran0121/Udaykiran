using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace call_by_value
{
    /*
     * arguments and paramters are same?
     * parameters:- parameters means int a, int b(here parameters are a and b)
     * arguments:- which gives the value to the parameters is called arguments like
     * ( int a=10,int b=20 , here a and b are parameters then the value assigned to them are called arguments)
     * >passing parameter mechanism is mainly 3 types they are:
     * 1,call by value /pass by value
     * 2,call by refrence/pass by reference
     * 3,call by out/pass by out
     * => call by value:
     * .*when we pass the value to the funcion or method that called function modification is not reflected then it is called call by value
     * =>call by refrence:
     * .* when we pass value to the function or method then that called function modification is reflected to the original.
     * =>call by out:
     * .* whithout passing the values to the function the funtion modification is reflected to original is called call by out.
     * 
     */
    internal class Program
    {
        class myclass
        {
            internal void nothing(int a)
            {
                a += 5000;
                Console.WriteLine("value of a is " + a);

            }

        }
        static void Main(string[] args)
        {
            myclass obj = new myclass();
            int x = 5000;
            obj.nothing (x);
            Console.WriteLine("value of x is " + x);
        }
    }
}
