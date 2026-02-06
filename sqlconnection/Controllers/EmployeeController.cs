using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sqlconnection.Models;

namespace sqlconnection.Controllers
{

    public class EmployeeController : Controller

    {
        EmployeeDetails yes = new EmployeeDetails();
        public ActionResult Index()
        {
            return View(yes.EmployeesTable.ToList());
        }
        public ActionResult Details(int? ID)
        {
            if (ID == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest, "ID is not found");
            }
            Employee Employee = yes.EmployeesTable.Find(ID);
            {
                if (Employee == null)
                {
                    return new HttpStatusCodeResult(System.Net.HttpStatusCode.NotFound, "Employee not found");
                }
                return View(Employee);
            }

        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        /*/public ActionResult Create (FormCollection frmCollection)
        {
        Employee emp = new Employee();
            emp.EmpName = frmCollection["EmpName"];
            emp.EmpSalary = Convert.ToDecimal(frmCollection["EmpSalary"]);

        yes.EmployeesTable.Add(emp);
            yes.SaveChanges();
            return RedirectToAction("Index");
    }
    */
      /*  public ActionResult Create(string EmpName, decimal EmpSalary)
        {
            Employee emp = new Employee();
            emp.EmpName = EmpName;
            emp.EmpSalary = EmpSalary;
            yes.EmployeesTable.Add(emp);
            yes.SaveChanges();
            return RedirectToAction("Index");
        }
        */
      public ActionResult Create(Employee emp)
        {
            yes.EmployeesTable.Add(emp);
            yes.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Edit(int ID)
        {
            Employee Employee = yes.EmployeesTable.Find(ID);
            UpdateModel(Employee);
            yes.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult Delete(int? ID)
        {
            if(ID==null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest, "ID is not found");
            }
            Employee Employee= yes.EmployeesTable.Find(ID);
            {
                if (Employee == null)
                {
                    return new HttpStatusCodeResult(System.Net.HttpStatusCode.NotFound, "Employee not found");
                }
                return View(Employee);
            }
        }

        [HttpPost]
        public ActionResult Delete(int ID)
        {
            Employee Employee = yes.EmployeesTable.Find(ID);
            yes.EmployeesTable.Remove(Employee);
            yes.SaveChanges();
            return RedirectToAction("Index");
        }





    }

}