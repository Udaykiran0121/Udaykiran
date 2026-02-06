using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /*
     * Inheritance:- inheritance is nothing than inheriting from one class to another class
     * > A class which gives the members is called super class or parent class or base class
     * > A class which is consuming members is called sub class/child class/derived class.
     * > Because of inheritance sub class can access super class and as well as using  sub class object we can access super class also.
     * 
     * Types of inheritances:
     * 1,Single inheritance
     * 2,Mutilevel Inheritance
     * 3,Multiple inheritance
     * 4,hirorchical inheritance
     * 5,Hybrid inheritance
     * 
     * Single Inheritance:-
     * > single inheritance is inheriting from one class to another class is called single inheritance.
     * syntax:
     * class c1
     * {
     * }
     * class c2:c1
     * {
     * }
     * 
     * 
     */

    class university
    {
        string unname;
        string unloc;
        int uncode;
        internal university(string unname, string unloc, int uncode)
        {
            this.unname = unname;
            this.unloc = unloc;
            this.uncode = uncode;
        }
        internal void universitydisplay()
        {
            Console.WriteLine("university name is :" + unname);
            Console.WriteLine("university location is :" + unloc);
            Console.WriteLine("university code is :" + uncode);

        }
        class student:university 
        {
            int id;
            string name;
            string branch;
            internal student(int id, string name, string branch):base ("JBIET","MOINABAD",500036)
            {
                this.id = id;
                this.name = name;
                this.branch = branch;
            }
            internal void studentdiaplayinfo()
            {
                Console.WriteLine("student id is :" + id);
                Console.WriteLine("student name is :" + name);
                Console.WriteLine("student branc is :" + branch);

            }
        }


        internal class Program
        {
            static void Main(string[] args)
            {
                student s = new student(211, "uday kiran", "EEE");
                s.studentdiaplayinfo();
                s.universitydisplay();
            }
        }
    }
}
