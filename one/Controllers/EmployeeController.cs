using one.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace one.Controllers
{
    public class EmployeeController : Controller
    {
        static List<Employee> empList = new List<Employee>()
        {
         new Employee {Id=1,EmpName="uday kiran",Designation="dot net developer",Salary=30000.00},
         new Employee{Id=2, EmpName="raj kumar",Designation="full stack developer",Salary=35000.00}
        
        };
        
        public ActionResult Details()
        {
            return View(empList);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            empList.Add(emp);
            return RedirectToAction("Details");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var emp = empList.FirstOrDefault(e => e.Id == id);
            return View (emp);
        }
        [HttpPost]
        public ActionResult Edit(Employee emp)
        {
            var oldemp=empList.FirstOrDefault(e => e.Id ==emp.Id);
             oldemp.EmpName=emp.EmpName;
             oldemp.Designation=emp.Designation;
             oldemp.Salary=emp.Salary;
            return RedirectToAction("Details");
        }
       


    }
}