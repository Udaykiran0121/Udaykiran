using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Demo1.Controllers
{
    public class HomeContoller:Controller
    {
        public ViewResult Index()
        {
            ViewData["name"] = "uday kiran";
            return View();
        }
    }
}