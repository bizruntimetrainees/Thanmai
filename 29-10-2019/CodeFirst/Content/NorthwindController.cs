using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFirst.Models;

namespace CodeFirst.Content
{
    public class NorthwindController : Controller
    {
        NorthWindContext db = new NorthWindContext();
        // GET: Northwind
        public ActionResult Index()
        {
            db.CategoriesTable.ToList();
            db.ProductsTable.ToList();
            return View();
        }
    }
}