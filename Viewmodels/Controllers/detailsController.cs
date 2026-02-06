using Microsoft.AspNetCore.Mvc;
using Viewmodels.Models;

namespace Viewmodels.Controllers
{
    public class detailsController : Controller
    {
        public IActionResult Index()
        {
            var details = new List<details>()
            {
               new details { Id = 1, Name = "Item1", Description = "This is item 1" },
                new details { Id = 2, Name = "Item2", Description = "This is item 2" },


            };
            ViewData["details"]= "details list";
            return View(details);
        }
    }
}
