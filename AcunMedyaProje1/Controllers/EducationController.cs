using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProje1.Models;

namespace AcunMedyaProje1.Controllers
{
    public class EducationController : Controller
    {
        // GET: Education
        DBAcunmedyaAkademiEntities2 db = new DBAcunmedyaAkademiEntities2();
        public ActionResult Index()
        {
            var values = db.TBL_Education.ToList();
            return View(values);
        }

        public ActionResult DeleteEducation(int id)
        {
            var values = db.TBL_Education.Find(id);
            db.TBL_Education.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateEducation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateEducation(TBL_Education education)
        {
            db.TBL_Education.Add(education);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateEducation(int id)
        {
            var value = db.TBL_Education.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateEducation(TBL_Education model)
        {
            var value = db.TBL_Education.Find(model.EducationID);
            value.Name = model.Name;
            value.Section = model.Section;
            value.StartedYear = model.StartedYear;
            value.EndYear = model.EndYear;
            value.Description = model.Description;
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}