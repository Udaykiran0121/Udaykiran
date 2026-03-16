using EnterpriseHRMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EnterpriseHRMS.Controllers
{
    [Authorize(Roles ="HR")]
    public class HRDashboardController : Controller
    {
        private ApplicationDbContext db =new ApplicationDbContext();
        public ActionResult Index()
        {
            var totalEmployees = db.Employees.Count(e => e.Role == "Employees" && !e.IsDeleted);
            var totalManagers = db.Employees.Count(e => e.Role == "Manager" && !e.IsDeleted);
            var totalAttendance=db.Attendances.Count(a=>a.Date==System.DateTime.Today);
            ViewBag.TotalEmployees = totalEmployees;
            ViewBag.TotalManagers = totalManagers;
            ViewBag.Attendances = totalAttendance;
            return View();
        }

        // GET: HRDashboard/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HRDashboard/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HRDashboard/Create
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

        // GET: HRDashboard/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HRDashboard/Edit/5
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

        // GET: HRDashboard/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HRDashboard/Delete/5
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
