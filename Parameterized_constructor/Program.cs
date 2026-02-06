using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameterized_constructor
{
    internal class Program
    {
        class myclass
        {
            int a;
            int b;
            internal myclass(int a, int b)
            {
                this.a = a;
                this.b = b;

            }
            internal void display()
            {
                Console.WriteLine("a value is :" + a);
                Console.WriteLine("b value is :" + b);
            }
            class employee
            {
                int emid;
                string emname;
                double emsal;


                internal employee(int Emid, string Emname, double Emsal)
                {
                    emid = Emid;
                    emname = Emname;
                    emsal = Emsal;
                }
                internal void displayemployee()
                {
                    Console.WriteLine("employee id is :" + emid);
                    Console.WriteLine("employee name is:" + emname);
                    Console.WriteLine(" employee salary is:" + emsal);



                }




                internal class program
                {

                    static void Main(string[] args)
                    {
                        myclass obj = new myclass(10, 20);
                        obj.display();
                        employee emp = new employee(100, "sung jin-woo", 250000);
                        emp.displayemployee();

                    }
                }
            }
        }
    }
}
