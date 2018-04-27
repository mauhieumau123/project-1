using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model.EF;
using System.Web.Mvc;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        // GET: Admin/Product
        OnlineShopDbContext db = new OnlineShopDbContext();
        public ActionResult Index()
        {
            var model = new Product();
            ViewBag.Product = db.Products.ToList();
            return View();
        }
    }
}