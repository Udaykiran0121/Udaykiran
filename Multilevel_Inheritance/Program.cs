using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multilevel_Inheritance
{
    /*
     * Multi-level Inheritance :
     * > multi level inheritance is using one parent classs and two child classes 
     * ex: like one parent class and creating two child classes by consuming from parent classs
     * syntax:
     * class c1
     * {
     * }
     * class c2:c1
     * {
     * }
     * class c3:c2
     * {
     * }
     */

    class Acadamy
    {
        string acname;
        string acloc;
        int accode;

        internal Acadamy(String acname, string acloc, int accode)
        {
            this.acname = acname;
            this.acloc = acloc;
            this.accode = accode;
        }
        internal void Acadamydisplay()
        {
            Console.WriteLine(" acadamy name is :" + acname);
            Console.WriteLine("acadamy location is :" + acloc);
            Console.WriteLine("acadamy code is :" + accode);
        }
        class Employee : Acadamy
        {
            int emid;
            string emname;
            string emcategory;
            internal Employee(int id, string emname, string emcategory) : base("Nalgonda Police acadamy", "Nalgonda", 508211)
            {
                this.emid =id;
                this.emname = emname;
                this.emcategory = emcategory;
            }
            internal void Employeedisplay()
            {
                Console.WriteLine("employee id is :" + emid);
                Console.WriteLine("employee name is :" + emname);
                Console.WriteLine("employee category is :" + emcategory);

            }
            class Student : Employee
            {
                int batchno;
                string name;
                string native;
                internal Student(int batchno, string name, string native) : base(206710211, "Raj kumar", "sub Inspector")
                {
                    this.batchno = batchno;
                    this.name = name;
                    this.native = native;
                }
                internal void Studentdisplay()
                {
                    Console.WriteLine("Trainee batchno is :" + batchno);
                    Console.WriteLine("traniee name is :" + name);
                    Console.WriteLine("trainee native is :" + native);

                }
            }
        }
    }
    internal class Program
    {
        static void Main (string[] args)
        {
            Student  s = new Student (206710211, "raj kumar", "hyderabad");

        }
        
              
          
            
        
    
}
