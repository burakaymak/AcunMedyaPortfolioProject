using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProje1.Models;

namespace AcunMedyaProje1.Controllers
{
    public class TestominialController : Controller
    {
        // GET: Testominial
        DBAcunmedyaAkademiEntities2 db =  new DBAcunmedyaAkademiEntities2();
        public ActionResult Index()
        {
            var values = db.TBL_Testimonial.ToList();
            return View(values);
        }

        public ActionResult DeleteTestimonial(int id)
        {
            var values = db.TBL_Testimonial.Find(id);
            db.TBL_Testimonial.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateTestimonial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateTestimonial(TBL_Testimonial testimonial)
        {
            db.TBL_Testimonial.Add(testimonial);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var value = db.TBL_Testimonial.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateTestimonial(TBL_Testimonial model)
        {
            var value = db.TBL_Testimonial.Find(model.TestimonialID);
            value.TestimonialName = model.TestimonialName;
            value.Description2 = model.Description2;
            value.ImageURL = model.ImageURL;
            value.Description1 = model.Description1;
            value.Title = model.Title;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}