using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EnterpriseHRMS.Models;
using System.Linq;
using Antlr.Runtime.Misc;

namespace EnterpriseHRMS.Controllers
{
    
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            var total = db.Employees.Count(e=>e.IsDeleted==false);
            var totalHR=db.Employees.Count(e=>e.Role !=null && e.Role.ToLower().Contains("hr") && e.IsDeleted);
            var totalManagers = db.Employees.Count(e => e.Role != null && e.Role.ToLower().Contains("managers")&& e.IsDeleted);
            var active = db.Employees.Count(e => e.IsDeleted == false);
            var deleted=db.Employees.Count(e=>e.IsDeleted == true);
            var model = new DashboardView
            {
                TotalEmployees = total,
                TotalHR = totalHR,
                TotalManagers=totalManagers,
                ActiveEmployees = active,
                DeletedEmployees = deleted,
                EmployeesAddedToday = db.Employees.Count(e => e.CreatedDate >= DateTime.Today),
                RecentEmployees = db.Employees.Where(e => e.IsDeleted == false).OrderByDescending(e => e.CreatedDate).Take(5).ToList()
            };

            return View(model);
        }
        
        

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult AccessDenied()
        {
                       return View();
        }
    }
}