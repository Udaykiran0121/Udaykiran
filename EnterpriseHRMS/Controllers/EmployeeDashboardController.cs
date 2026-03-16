using EnterpriseHRMS.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Web.Mvc;

namespace EnterpriseHRMS.Controllers
{
    [Authorize(Roles = "Employee")]
    public class EmployeeDashboardController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            var employee = db.Employees
                             .FirstOrDefault(e => e.UserId == userId && !e.IsDeleted);
            var todayAttendance = db.Attendances
                .Where(a => a.UserId == userId && a.Date == DateTime.Today)
                .OrderByDescending(a => a.LoginTime)
                .FirstOrDefault();

            ViewBag.Employee = employee;
            ViewBag.TodayAttendance = todayAttendance;

            return View();
        }
        public ActionResult Profile()
        {
            var userId= User.Identity.GetUserId();
            var employee = db.Employees.FirstOrDefault(e=>e.UserId == userId && !e.IsDeleted);
            return View(employee);
        }
    }
}