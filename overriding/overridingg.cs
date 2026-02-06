using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overridingg 
{
    class BaseClass
    {
        public virtual void Display()
        {
            Console.WriteLine("Display method from BaseClass");
        }
    }
    class DerivedClass : BaseClass
    {
        public override void Display()
        {
            Console.WriteLine("Display method from DerivedClass");
        }
    }

    internal class program 
    {
        static void Main (string[] args)
        {
            BaseClass baseObj = new BaseClass();
            baseObj.Display(); // Output: Display method from BaseClass
            DerivedClass derivedObj = new DerivedClass();
            derivedObj.Display(); // Output: Display method from DerivedClass
            //BaseClass polymorphic
            BaseClass polymorphicObj = new DerivedClass();
            polymorphicObj.Display(); // Output: Display method from DerivedClass
        }
    }
}