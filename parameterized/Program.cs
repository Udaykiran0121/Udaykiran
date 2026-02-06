using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameterized
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace EmployeeDetailss
    {
        /*
         * Define a class employee with two behaviours
         * 1)accepting employee info
         * 2)displaying employee info.
         */

        class Employee
        {
            int empid;
            string empname;
            double esal;
            public void AcceptEmployeeInfo()
            {
                Console.WriteLine("Enter employee id");
                empid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter employee name");
                empname = Console.ReadLine();
                Console.WriteLine("Enter employee salary");
                esal = double.Parse(Console.ReadLine());

            }
            internal void DisplayInfo()
            {
                Console.WriteLine("Employee id is:" + empid);
                Console.WriteLine("Employee name is:" + empname);
                Console.WriteLine("Employee sal is:" + esal);
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Employee emp = new Employee();
                emp.AcceptEmployeeInfo();
                emp.DisplayInfo();
                Employee e2 = new Employee();
                e2.AcceptEmployeeInfo();
                e2.DisplayInfo();
            }
        }
    }
}
    
