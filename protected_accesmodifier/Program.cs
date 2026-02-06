using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protected_accesmodifier
{
    class class1
    {
        protected int x = 10;
         
        public  void display()
        {
            Console.WriteLine("value of x is :" + x);
        }
        class class2:class1 
        {
        public  void method2()
            {
                Console.WriteLine("value of x under method 2 is :" + x);
            }
        }


        internal class Program
        {
            static void Main(string[] args)
            {
                class2 obj = new class2();
                obj.display();
                obj.method2();
                
            }
        }
    }
}
