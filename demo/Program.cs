using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
            //write line: prints the input value which is alredy given by the programmer.
        {
            //int a= 10;
            //Console.WriteLine("a value is:{0} ", a);
            //Console.Read();
            //READ LINE: The read line says to the programmer to enter the input value before printing the output.
            int id;
            Console.WriteLine("enter the id value:");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("id value is :{0}" , id);
            Console.Read();
            


        }
    }
}
