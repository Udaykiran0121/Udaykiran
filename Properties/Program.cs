using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    /*
     * prperties;
     * >property:- property is a member of class where we will assign the value to a variable and we will use to retirve the value from a variable is called property
     * > both prperty name and variable name are same
     * >but property name should start with capital letter and variable name shoud starts with small letter
     * >ex: Eno--Property name
     *      eno--varible name
     * > properties are divided into several types 
     * 1,read only property
     * #it contains only get accessor
     * 2,write only property
     * # it contains only set accessor
     * 3,read and write property
     * # it contains both get and set accessors
     * Again it divided into two types they are :
     * 1,static property 
     * 2,instance property
     * 
     * >static property:-
     * $To defne statice property we must use static keyword.
     * $ The purpose of static property is to intialize and as well as to retrive the static variables
     * >Instance property:-
     * $ To define instance property we don't use static keyword.
     * $ The purpose of instance property is to intilize and retirve the instance variables
     * 
     * WHEN PROPERTY:
     * >whenever we want to assign the values to a variable of a class or whenever we want to retirve the values from the variable form outside the class 
     * 
     * 
     */  
    class employee
    {
        int eid;
        int eno;
        string ename;

        internal int Eid
        {
            get
            {
                return eid;
            }
            set
            {
                eid = value;

            }
        }
        internal int Eno
        {
            get
            {
                return eno;

            }
            set
            {
                eno = value;
            }
        }
        internal string Ename
        {
            get
            {
                return ename;

            }
            set
            {
                ename = value;
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                employee emp = new employee();
                Console.WriteLine("enter emplyee id");
                emp.Eid = int.Parse(Console.ReadLine());
                Console.WriteLine("enter employee eno");
                emp.Eno = int.Parse(Console.ReadLine());
                Console.WriteLine("enter employee ename");
                emp.Ename =(Console.ReadLine());

                Console.WriteLine("employee id is " + emp.Eid);
                Console.WriteLine("employee eno is " + emp.eno);
                Console.WriteLine("employee ename is " + emp.ename);


                
            }
        }
    }
}
