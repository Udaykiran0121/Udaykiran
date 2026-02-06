using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your choice:");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
            Console.WriteLine("your name is uday kiran"); break;
                case 2:
            Console.WriteLine(" your name is raj kumar"); break;
               case 3:
            Console.WriteLine(" your name is rakesh");break;
               case 4:
            Console.WriteLine("your name is lohith");  break;
                default:
                    Console.WriteLine("nothing matched"); break;
            }
            Console.Read();
        }
       
    }
}
