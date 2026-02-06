using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using Sqldata.Models;

namespace Sqldata.Controllers
{
    public class ProductsController : Controller
    {
        ProductsDetails Productss=new ProductsDetails();
        public ActionResult Index()
        {
            return View(Productss.ProductsTable.ToList());
        }
        public ActionResult Details(int ? ID)
        {
            if (ID == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest, "ID of products in not Found");
            }
            Products Product = Productss.ProductsTable.Find(ID);
            {
                if (Product == null)
                {
                    return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest, "the Product is not found");
                }
                return View(Product);
            }
        }
        public ActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        /*public ActionResult Create(FormCollection frmCollection)
        {
            Products pro = new Products();
            pro.ProductID = Convert.ToInt32(frmCollection["ProductID"]);
            pro.ProductName = frmCollection["ProductName"];
            pro.Price = Convert.ToDecimal(frmCollection["Price"]);
            Products.ProductsTable.Add(pro);
            Products.SaveChanges();
            return RedirectToAction("Index");

        }*/
        public ActionResult Create(Products pro)
        {
            Productss.ProductsTable.Add(pro);
            Productss.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}