using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProje1.Models;

namespace AcunMedyaProje1.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        DBAcunmedyaAkademiEntities2 db = new DBAcunmedyaAkademiEntities2();
        public ActionResult Index()
        {
            var values = db.TBL_About.ToList();
            return View(values);
        }

        public ActionResult DeleteAbout(int id)
        {
            var values = db.TBL_About.Find(id);
            db.TBL_About.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateAbout()
        {
           return View();
        }

        [HttpPost]
        public ActionResult CreateAbout(TBL_About about)
        {
            db.TBL_About.Add(about);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var value = db.TBL_About.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateAbout(TBL_About model)
        {
            var value = db.TBL_About.Find(model.AboutID);
            value.Title = model.Title;
            value.Description1 = model.Description1;
            value.Description2 = model.Description2;
            value.ImageURL = model.ImageURL;
            value.Age = model.Age; 
            value.BirthDay = model.BirthDay;
            value.Phone = model.Phone;
            value.Email = model.Email; 
            value.Freelance = model.Freelance;
            value.City = model.City;
            value.WebSite = model.WebSite;
            db.SaveChanges();
            return RedirectToAction("Index");
            
        }
    }
}