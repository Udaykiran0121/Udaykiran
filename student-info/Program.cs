using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_info
{
    internal class Program
    {
        class employee
        {
            int empid;
            string name;
            float age;
            double workingdays;
            char leaves;
            int salary;

            public void accepttEmployeeDetails()
            {
                Console.WriteLine("enter employee id");
                empid = int.Parse(Console.ReadLine());
                Console.WriteLine(" enter employee name");
                name = Console.ReadLine();
                Console.WriteLine(" enter employee age");
                age = float.Parse(Console.ReadLine());
                Console.WriteLine("enter employee workingdays");
                workingdays = double.Parse(Console.ReadLine());
                Console.WriteLine("enter employee leaves");
                leaves = char.Parse(Console.ReadLine());
                Console.WriteLine("enter employee salary");
                salary = int.Parse(Console.ReadLine());
                
            }

            internal void displayinfo()
            {
                Console.WriteLine("employee eid is:" + empid);
                Console.WriteLine("employee name is :" + name);
                Console.WriteLine("employee age is :" + age);
                Console.WriteLine("employee workingdays is:" + workingdays);
                Console.WriteLine("employee leaves are:" + leaves);
                Console.WriteLine("employee salary is :" + salary);
            }
        }

        static void Main(string[] args) // Fixed the method declaration to be the entry point of the program
        {
            employee emp = new employee(); // Create an instance of the employee class
            emp.accepttEmployeeDetails(); // Call the method to accept employee details
            emp.displayinfo(); // Call the method to display employee details
        }
    }
    }