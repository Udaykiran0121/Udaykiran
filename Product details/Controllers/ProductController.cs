using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Product_details.Models;

namespace Product_details.Controllers
{
    public class ProductController : Controller
    {
        ProductsData db = new ProductsData();
          public ViewResult Details()
        {
            return View(db.ProductsList.ToList());
        }
        public ActionResult Index(int Id)
        {
            Products Products= db.ProductsList.Single(x => x.productId == Id);
            return View(Products);
        }
    }
}