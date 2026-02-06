using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtual_overridden
{
    class Baseclass
    {
        public virtual void Display()
        {
            Console.WriteLine("display method  is from baseclass");
        }
    }
    class Derivedclass: Baseclass 
    {
        public override void Display ()

        {
            Console.WriteLine("diaplay method form derivedclass");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Baseclass naveen = new Derivedclass();
            naveen.Display();
           
        }
    }
}
