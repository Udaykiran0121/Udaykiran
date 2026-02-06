using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace explicity_casting
{
    internal class Program

    {
        /*type casing:-
         * type casting is the process of converting data from one type to another.
         * -types of castings:
         * 1,impilict type casting
         * 2,explicit type casting
         * => Implicit :
         * >without programmer intervention a data is converted from one type to another.
         * >example:int to float, flaot to double ,etc,
         * 
         * =>explict:
         * >a programmer converts data from one type to another.
         * example: decimal to int, float to int etc,
         * 
         */ 
        static void Main(string[] args)
        {
            //decimal num = 10.5m;
            //int wholenumber = (int)num;
            //Console.WriteLine("original decimal number:" + num);
            //Console.WriteLine("after explicit type casting to int :" + wholenumber);

            int num  = 100;
            float  result = num;
            Console.WriteLine("original int number is:" + num);
            Console.WriteLine("after implicit type casting to decimal:" +result );



        }

    }
}
