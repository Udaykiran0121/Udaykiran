using Microsoft.AspNetCore.Mvc;
using ActionMethods.Models;

namespace ActionMethods.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Employee()
        {
            var list = new List<Employee>();
            {
                new Employee { Id = 1, Name = "Alice", Description = "Software Engineer" };
                new Employee { Id = 2, Name = "Bob", Description = "Project Manager" };
                new Employee { Id = 3, Name = "Charlie", Description = "Designer" };
            }
            ViewData["Employee"] = "Employee Details";
            return View();
        }
    }
}
