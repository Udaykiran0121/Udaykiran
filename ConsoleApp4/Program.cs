using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string input = "naresh";
            char[] yes = input.ToCharArray();
            Array.Reverse(yes);
            string result = new string(yes);
            Console.WriteLine(result);*/

            /*string input = "programming";
            string result = new

                string(input.Distinct().ToArray());
            Console.WriteLine(result);*/

            /* string yes = "dogs";
             string result = new string(yes.Reverse().ToArray());
             if (yes == result)
             {
                 Console.WriteLine("it is a palindrome");

             }
             else
             {
                 Console.WriteLine("it is not palindorme");
             }
                 Console.WriteLine(result);*/

            /*int num = 7;
            int factorial = 1;
            for (int i=2;i<num;i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);*/

            int a = 0, b = 1, c;
            Console.WriteLine(a + " " + b + " ");
            for (int i=2;i<10;i++)
            {
                c = a + b;
                Console.WriteLine(c+" ");
                a = b;
                b = c;
            }

        }
    }
}
