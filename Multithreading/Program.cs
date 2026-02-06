using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading
{
    class myclass
    {
        internal void Method()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " " + i);

                if (i == 5)
                {
                    Thread.CurrentThread.Suspend();

                }
            }
        }
        
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            myclass obj = new myclass();
            ThreadStart tstart = new ThreadStart(obj.Method);
            Thread thr1 = new Thread(tstart);
            thr1.Start();
            thr1.Name = "Uday";
            Thread thr2 = new Thread(tstart);
            thr2.Start();
            thr2.Name = "raj";

           
        }
    }
}
