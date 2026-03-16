using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            bool prime = true;
            if(n<=1)
                prime = false;
            for (int i = 2; i * i <= n;i++)
            {
                if(n%i==0)
                {
                    prime = false;
                    break;
                }
            }
            Console.WriteLine(prime ? "is prime", "is not prime");
        }
    }
}
