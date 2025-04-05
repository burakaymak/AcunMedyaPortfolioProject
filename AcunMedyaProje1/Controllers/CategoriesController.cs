using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProje1.Models;

namespace AcunMedyaProje1.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        DBAcunmedyaAkademiEntities2 db = new DBAcunmedyaAkademiEntities2();
        public ActionResult Index()
        {
            var values = db.TBL_Category.ToList();
            return View(values);
        }

        public ActionResult DeleteCategory(int id)
        {
            var values = db.TBL_Category.Find(id);
            db.TBL_Category.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreatCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreatCategory(TBL_Category category)
        {
            db.TBL_Category.Add(category); 
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var values = db.TBL_Category.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateCategory(TBL_Category model)
        {
            var value = db.TBL_Category.Find(model.CategoryID);
            value.CategoryName = model.CategoryName;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}