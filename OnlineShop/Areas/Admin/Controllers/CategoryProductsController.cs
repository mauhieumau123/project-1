
using Model.Dao;
using Model.EF;
using OnlineShop.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineShop.Common;
using System.Web.Mvc;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class CategoryProductsController : Controller
    {
        OnlineShopDbContext db = new OnlineShopDbContext();
        // GET: Admin/CategoryProducts
        public ActionResult Index()
        {
            var model = new ProductCategory();
            ViewBag.ProductCategory = db.ProductCategories.ToList();
            return View();
        }

        // GET: Admin/CategoryProducts/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/CategoryProducts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/CategoryProducts/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/CategoryProducts/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/CategoryProducts/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/CategoryProducts/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/CategoryProducts/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
