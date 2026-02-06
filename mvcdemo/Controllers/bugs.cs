using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcdemo.Controllers
{
    public class bugs:Controller
    {
        public ViewResult Index()
        {
            ViewData.Add("string", "Jhon");
            return View();
        }
    }
}