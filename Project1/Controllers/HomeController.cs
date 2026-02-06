using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project1.Models;

namespace Project1.Controllers
{
    public class HomeController : Controller
    {
       
        
        public ActionResult Index()
        {
            ViewData["details"] =(1, "uday kiran", "dot net");
            return View();
           
        }
    }
}