using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace practice21
{
    public class program
    {
        static void Main(string[] args)
        {
            int n = 30;
            bool Prime = true;
            if (n <= 1)
                Prime = false;
            for(int i=2;i*i<=n;i++)
            {
                if(n%i==0)
                {
                    Prime = false;
                    break;
                }

            }
            if (Prime)
                Console.WriteLine("Prime Number");
            else
                Console.WriteLine("Not a Prime Number");


        }

    }
}