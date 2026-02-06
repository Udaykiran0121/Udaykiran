using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_types
{
 //data types are divided into two catogeries:
 //1.value data type
 //       2,refrence data type
 //value data type: value data type stores the  actual data int the memenory
 //refrence data tyoe: it stores the adddress of the data in the varuable
 //value data typess:
 //1,int: it indicates a whole number
 //2,float: it indicates  a decimal number
 //4,charracter: it indicates a si                           
 //5,boolean:it indicates true or false
 //6,

 
    internal class Program
    {
        static void Main(string[] args)
        {
            //short c = 1000;
            //Console.WriteLine($"short :{c}");
            //Console.WriteLine("value of a is :" + c);
            //Console.WriteLine("size of short is :" + sizeof(short) + "bytes");
            //Console.WriteLine("base of short is:" + c.GetType());
            //Console.WriteLine("short min value is :" + short.MinValue);
            //Console.WriteLine("short max value is :" + short.MaxValue);
            //Console.WriteLine("ushort min value is :" + ushort.MinValue);
            //Console.WriteLine("ushort max value is :" + ushort.MaxValue);
            //int a = 1000;
            //Console.WriteLine($"int :{a}");
            //Console.WriteLine(" value of a is :" + a);
            //Console.WriteLine("int min value is :" + int.MinValue);
            //Console.WriteLine("int max value is ;"+ int.MaxValue);
            //Console.WriteLine("uint min value is :" + uint.MinValue);
            //Console.WriteLine("int max value is :" + int.MaxValue);
            //Console.WriteLine("uint max vallue is :" + uint.MaxValue);
            //Console.WriteLine("base type of int is :" + a.GetType());
            //Console.WriteLine(" size of int is :" + sizeof(int) + "bytes");

            float b = 1000;
            Console.WriteLine($"float :{b}");
            Console.WriteLine(" value of a is :" + b);
            Console.WriteLine("float min value is :" + float.MinValue);
            Console.WriteLine("float max value is ;" + float.MaxValue);
            Console.WriteLine("float max value is :" + float.MaxValue);
            Console.WriteLine("base type of float is :" + b.GetType());
            Console.WriteLine(" size of float is :" + sizeof(float ) + "bytes");





        }
    }
}
