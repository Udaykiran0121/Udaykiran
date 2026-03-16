using EnterpriseHRMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EnterpriseHRMS.Controllers
{
    public class ManagerDashboardController : Controller
    {
        private ApplicationDbContext db=new ApplicationDbContext();
        public ActionResult Index()
        {
            var model = new ManagerDashboardViewModel();
            model.TotalEmployees = db.Employees.Count(e => !e.IsDeleted);
            model.TodayAttendance = db.Attendances.Count(a => a.Date == DateTime.Today);
            return View(model);
        }
        public ActionResult Employees()
        {
            var employees = db.Employees.Where(e => !e.IsDeleted).ToList();
            return View(employees);
        }
        public ActionResult Attendance()
        {
            var attendance=db.Attendances.OrderByDescending(a=>a.LoginTime).ToList();
            return View(attendance);
        }
    }
}