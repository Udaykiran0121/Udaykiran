using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace multithreading_suspend
{
    class myclass
    {
        internal void method()
        {
            for(int i=0;i<=10;i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " " + i);
                Thread.Sleep(1000);
                if (i==6)
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
            ThreadStart uday = new ThreadStart(obj.method);
            Thread thr1 = new Thread(uday);
            thr1.Start();
            thr1.Name = "nani";
            Thread thr2 = new Thread(uday);
            thr2.Start();
            thr2.Name = "raj";
        }
    }
}
