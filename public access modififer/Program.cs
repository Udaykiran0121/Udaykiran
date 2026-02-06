using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace public_access_modifier
{
    class class1
    {
        public int a = 10;
        public int b = 20;
    
    internal void display()
        {
            Console.WriteLine("value of a is :" + a);
            Console.WriteLine("value of b is :" + b);
        }
        class class2
        {
            class1 obj = new class1();
            internal void method2()
            {
                Console.WriteLine("value of a is under method 2 is " + obj .a);
                Console.WriteLine("value of b is under method 2 is :" + obj.b);

            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                class1 obj = new class1();
                obj.display();
                class2 name = new class2();
                name.method2();
                Console.WriteLine("the main method value is :" + obj.a);
                Console.WriteLine("the main method value is :" + obj.b);





            }
        }
    }
}
