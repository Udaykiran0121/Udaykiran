using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_types

{
    //data types:the data types are divided into 2 types they are:
    //1,value data type 
    //2,refrence dat type
    //Value Type:- it cosnsist of fixed size and range
    //data type is divided into 4types;
    //1,integral type
    //2,floating type
    //3,character type
    //4,boolean type
    //Reference type;- based on the address it works
    //it is divided into 2types;
    //1,sttring 
    //2,object
    // intergral type is divided into 2types;
    // 1,signed type
    // 2,unsigned type
    // -signed type: it accepts both postive and negative vakues
    // 1,short-Min value is -32768 and max vakue is 32767 = 65535
    // and base type is :system int.16 and size is 2 bytes
    // 2,int
    // 3,long
    // -unsigned type:it accpts only postive values
    // 1.ushort - min value is 0 and max value is 65535 and base type is  sysytem.uint.16 and size is 2 bytes
    // 2,uint
    // 3,ulong
    // SYNTAX:-
    // data type varaiabele =value;


    internal class Program
    {
        static void Main(string[] args)
        {
            ushort a = 65535;
            Console.WriteLine("the value of a is :" + a);
            Console.WriteLine(" the min value of ushort is:" + ushort.MinValue);
            Console.WriteLine("the max value of ushort is:" + ushort.MaxValue);
            Console.WriteLine("the size of ushort is :" + sizeof(ushort));
            Console.WriteLine("type of a is :" + a.GetType());
            Console.WriteLine("bsase type of ushort is:" + typeof(ushort).BaseType);
        }
    }
}
