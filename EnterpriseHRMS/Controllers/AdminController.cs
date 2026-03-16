
using EnterpriseHRMS.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace EnterpriseHRMS.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private ApplicationUserManager _userManager;

        public AdminController()
        {
        }

        public AdminController(ApplicationUserManager userManager)
        {
            _userManager = userManager;
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        public ActionResult Index()
        {
            var Model = new AdminViewModel();
            Model.TotalUsers = db.Users.Count();
            Model.TotalCompanyUsers=db.Users.Count(u=>db.Employees.Any(e=>e.UserId==u.Id && !e.IsDeleted));
            Model.TotalPublicUsers = db.Users.Count(u => !db.Employees.Any(e => e.UserId == u.Id && !e.IsDeleted));
            Model.TotalEmployees = db.Employees.Where(e =>!e.IsDeleted).Count();
            Model.TotalHR = db.Employees.Where(e=>e.Role=="HR" && !e.IsDeleted).Count();
            Model.TotalManagers = db.Employees.Count(e=>e.Role!=null && e.Role.ToLower().Trim()=="Manager"&&!e.IsDeleted);

            return View(Model);
        }
        public ActionResult Users()
        {
            var Users = db.Users.ToList();
            return View(Users);
        }

        public ActionResult Employees()
        {
            var employees = db.Employees
                              .Where(e =>(e.Role=="Employee" || e.Role==null) && !e.IsDeleted)
                              .ToList();

            return View(employees);
        }
        public ActionResult HR()
        {
            var hrEmployees = db.Employees.Where(e => e.Role == "HR" && !e.IsDeleted).ToList();
            return View("Employees", hrEmployees);
        }
        public ActionResult Managers()
        {
            var managers = db.Employees.Where(e=>e.Role=="Manager" && !e.IsDeleted).ToList(); 
            return View("Employees", managers);
        }
        public ActionResult PublicUsers()
        {
            var employeeUserIds = db.Employees.Where(e=>!e.IsDeleted).Select(e => e.UserId).ToList();

            var PublicUsers = db.Users
                                .Where(u => !employeeUserIds.Contains(u.Id))
                                .ToList();

            return View(PublicUsers);
        }
        private System.Collections.Generic.List<EmployeeModel> GetEmployeesByRole(string roleName)
        {
            var role = db.Roles.FirstOrDefault(r => r.Name == roleName);

            if (role == null)
                return new System.Collections.Generic.List<EmployeeModel>();

            var employees = db.Employees.Include(e=>e.User)
                .Where(e => e.User.Roles.Any(r => r.RoleId == role.Id) && !e.IsDeleted)
                .ToList();

            return employees;
        }
        public ActionResult Attendance()
        {
            var data=db.Attendances.Include(a=>a.User).ToList();
            return View(data);
        }
    }
    
}
