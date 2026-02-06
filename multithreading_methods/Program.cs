using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace multithreading_methods
{
    class myclass
    {
        internal void Method1()
        {
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine("method1 value is :" + i);
                }
            }
        }
        internal void Method2()

        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("method2 value is :" + i);
            }

        }
    }
            

            

    internal class Program
    {
        static void Main(string[] args)
        {
            myclass obj = new myclass();
            ThreadStart tstart = new ThreadStart(obj.Method1);
            Thread tr1 = new Thread(tstart);
            tr1.Start();
            ThreadStart tstart2 = new ThreadStart(obj.Method2);
            Thread thr2 = new Thread(tstart2);
            thr2.Start();
        }
    }
}
