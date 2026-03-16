using EnterpriseHRMS.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Web.Mvc;

namespace EnterpriseHRMS.Controllers
{
    public class SetupController : Controller
    {
        public ActionResult CreateRoles()
        {
            var context = new ApplicationDbContext();
            var roleManager = new RoleManager<IdentityRole>(
                new RoleStore<IdentityRole>(context));

            if (!roleManager.RoleExists("Admin"))
                roleManager.Create(new IdentityRole("Admin"));

            if (!roleManager.RoleExists("HR"))
                roleManager.Create(new IdentityRole("HR"));

            if (!roleManager.RoleExists("Employee"))
                roleManager.Create(new IdentityRole("Employee"));

            return Content("Roles created");
        }
    }
}
