using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace largestnumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter b number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter c number");
            int c = int.Parse(Console.ReadLine());
            int   largest = 10;
            if (a > b && a > c)
            {
                largest = a;
                Console.WriteLine("a is largest number {0}" ,largest);
            }
            else if (b > a && b > c)
            {
                largest = b;
                Console.WriteLine("b is largest number {0}"+ largest);
            }
            else
            {
                largest = c;
                Console.WriteLine("c is largest number {0}" ,largest);
            }
            }
        }
    }

