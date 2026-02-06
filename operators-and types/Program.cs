using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace operators_and_types
{
    internal class Program
    {
        /*operators:-
         * >operator which performs between two operands.
         * ex: a+b which means 'a' and 'b' are operands and + indicates the operator.
         * type of operators:
         * 1,arthimetic
         * 2,realational
         * 3,logical
         * 4,increment and decrement
         * 5,condional
         * 6,bitwise
         * ARTHIMETIC OPERATORS:-
         * 1,addition(+)
         * 2,substraction(-)
         * 3,divison(/)
         * 4,multiplication(*)
         * 5,modulus(%)
         * 
         * 
         */
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = a + b;
            Console.WriteLine("sum:"+c);

            a = 30;
            b = 20;
            c = a - b;
            Console.WriteLine("substraction:" + c);


            a = 10;
            b = 20;
            c = a * b;
            Console.WriteLine("multiplication :" + c);

            a = 20;
            b = 10;
            c = a / b;
            Console.WriteLine("division:" + c);

            a = 20;
            b = 10;
            c = a % b;
            Console.WriteLine("modulus :" + c);



        }
    }
}
