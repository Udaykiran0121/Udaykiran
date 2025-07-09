using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraypassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            //Console.WriteLine("value of a is :" + a);
            int[] arr = new int[5] { 10, 20, 30, 40, 50 };
            //Console.WriteLine("Enter of the array are:");
            //Console.WriteLine("first array in element is {0}:", arr[0]);
            //Console.WriteLine("second array in element is{0} :", arr[1]);
            //Console.WriteLine("third array in element is{0}:", arr[2]);
            //Console.WriteLine("fourth array in element is {0}:", arr[3]);
            //Console.WriteLine("fifth array in element is {0}:", arr[4]);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        
        }
    }
}

      









