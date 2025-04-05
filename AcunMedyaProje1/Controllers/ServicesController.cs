using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProje1.Models;

namespace AcunMedyaProje1.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        DBAcunmedyaAkademiEntities2 db = new DBAcunmedyaAkademiEntities2();
        public ActionResult Index()
        {
            var values = db.TBL_Services.ToList();
            return View(values);
        }

        public ActionResult DeleteService(int id)
        {
            var values = db.TBL_Services.Find(id);
            db.TBL_Services.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreateService()
        {
            return View();
        }

        [HttpPost]  
        public ActionResult CreateService(TBL_Services services)
        {
            db.TBL_Services.Add(services);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateService(int id)
        {
            var value = db.TBL_Services.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateService(TBL_Services model)
        {
            var value = db.TBL_Services.Find(model.ServiceID);
            value.Title = model.Title;
            value.Description = model.Description;
            value.IconURL = model.IconURL;
            value.Descripiton2 = model.Descripiton2;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}