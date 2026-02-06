using EsportsDetails.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EsportsDetails.Models;

namespace EsportsDetails.Controllers
{
    public class EsportsController : Controller
    {
        public EsportsConnections db = new EsportsConnections();
        public ActionResult Index()
        {
            return View(db.EsportsDetails.ToList());
        }
    }
}