using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCdatabinding.Models;

namespace MVCdatabinding.Controllers
{
    public class StudentsController : Controller
    {
        studentsdetails db=new studentsdetails();
       public ViewResult Index()
        {
            return View(db.StudentsTable.ToList()); 
        }

    }
}