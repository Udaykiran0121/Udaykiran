using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thread.sleep
{
    class myclass
    {
        internal void Method()
        {
            if (int  i = 0; i <= 10; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name +"thread is going to sleep");
                Thread.Sleep(5) ;
            }
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            myclass obj = new myclass();
            ThreadStart uday = new ThreadStart(obj.Method);
            Thread raju = new Thread(uday);
            raju.Start();
            Thread jashwanth = new Thread(uday);
            jashwanth.Start();
            raju.Name = "ABC";
            jashwanth.Name = "XYZ";
        }
    }
}
