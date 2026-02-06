using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace floating_datatype
{

    //Floatig data type:-
    //*floating data type is used store the decimal values.
    //it is a singke precision floating point data type 
    // its size is 4 bytes
    //range min value is: -3.402823E+38
    //      max value is: 3.402823E+38
    //base type is : sysytem .single
    
    //
    internal class Program
    {
        static void Main(string[] args)
        {

            float a = 101.5f;
            Console.WriteLine("the value of a is :" + a);
            Console.WriteLine("size of float is:" + sizeof(float));
            Console.WriteLine("min  value of float is:" + float.MinValue);
            Console.WriteLine("max value of float is:" + float.MaxValue);
            Console.WriteLine("base type of float is:" + typeof(float));
            Console.WriteLine("default value of float is:" + default(float));
            Console.WriteLine("max value of ufloat is :" + float.MaxValue);
            Console.WriteLine("min value of ufloat is:" + float.MinValue);

        }
    }
}
