using EnterpriseHRMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EnterpriseHRMS.Controllers
{
    public class DashboardViewController : Controller
    {
        private ApplicationDbContext db=new ApplicationDbContext();
        public ActionResult Index()
        {
            var model = new DashboardView
            {
                TotalEmployees = db.Employees.Count(e => !e.IsDeleted),
                ActiveEmployees = db.Employees.Count(e => !e.IsDeleted),
                DeletedEmployees = db.Employees.Count(e => e.IsDeleted),
                EmployeesAddedToday = db.Employees.Count(e => e.CreatedDate >= DateTime.Today),
                RecentEmployees = db.Employees.Where(e => !e.IsDeleted).OrderByDescending(e => e.CreatedDate).Take(5).ToList()

            };
            return View(model);
        }

        // GET: DashboardView/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DashboardView/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DashboardView/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DashboardView/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DashboardView/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DashboardView/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DashboardView/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
