using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProje1.Models;

namespace AcunMedyaProje1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DBAcunmedyaAkademiEntities2 db = new DBAcunmedyaAkademiEntities2 ();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialTestimonial()
        {
            var values = db.TBL_Testimonial.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialServices()
        {
            var values = db.TBL_Services.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialContact()
        {
            var values = db.TBL_Contact.ToList(); 
            return PartialView(values);
        }

        public ActionResult PartialMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult PartialMessage(TBL_Message message)
        {
            db.TBL_Message.Add(message);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public PartialViewResult PartialAbout()
        {
            var values = db.TBL_About.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialSlider()
        {
            var values = db.TBL_Slider.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialSkills()
        {
            var values = db.TBL_Skill.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialEducation()
        {
            var values = db.TBL_Education.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialJob()
        {
            var values = db.TBL_Job.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialCategory()
        {
            var values = db.TBL_Category.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialProject()
        {
            var values = db.TBL_Project.ToList();
            return PartialView(values);
        }


        
    }
}