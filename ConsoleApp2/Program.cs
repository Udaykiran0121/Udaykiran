using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = "level";
            string rev = "";
            for (int i=x.Length-1;i>=0; i--) 
            {
                rev+= x[i];
            }
            if (x==rev)
            
                Console.WriteLine(x + "is palindrome");

            
            else
            
                Console.WriteLine(x+"is not palindrome");
           
        }
    }
}
