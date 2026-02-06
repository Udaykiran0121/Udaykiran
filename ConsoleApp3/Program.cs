using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Program
    {
       static void Main()
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 10, 20, 30, 40 };
            jaggedArray[1] = new int[] { 50, 60, 70, };
            jaggedArray[2] = new int[] { 80, 90, 100 };
            for (int i = 0; i<jaggedArray.Length; i++)
            {
                for (int j=0;j<jaggedArray[i].Length;j++)
                {
                    Console.WriteLine(jaggedArray[i][j] + "");
                }
                Console.WriteLine();

            }


            
        }
            
        
    }
}
