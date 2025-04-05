using AcunMedyaProje1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaProje1.Controllers
{
    public class StatisticController : Controller
    {
        // GET: Statistic
        DBAcunmedyaAkademiEntities2 db = new DBAcunmedyaAkademiEntities2();
        public ActionResult Index()
        {
            ViewBag.categoryCount = db.TBL_Category.Count();
            ViewBag.testimonialCount = db.TBL_Testimonial.Count();
            ViewBag.projectCount = db.TBL_Project.Count(); 
            ViewBag.jobCount = db.TBL_Job.Count();
            ViewBag.serviceCount = db.TBL_Services.Count();
            ViewBag.skillCount = db.TBL_Skill.Count();
            ViewBag.testimonialCount = db.TBL_Testimonial.Count();
            ViewBag.messageCount  = db.TBL_Message.Count();
            ViewBag.lastCategory = db.TBL_Category.OrderByDescending(x => x.CategoryID).Select(x => x.CategoryName).FirstOrDefault();
            ViewBag.lastTestimonial = db.TBL_Testimonial.OrderByDescending(x => x.TestimonialID).Select(x => x.TestimonialName).FirstOrDefault();
            ViewBag.lastProject = db.TBL_Project.OrderByDescending(x => x.ProjectID).Select(x =>x.ProjectName).FirstOrDefault();
            ViewBag.lastJob = db.TBL_Job.OrderByDescending(x => x.JobID).Select(x => x.Title).FirstOrDefault();
            ViewBag.lastService = db.TBL_Services.OrderByDescending(x => x.ServiceID).Select(x => x.Title).FirstOrDefault();
            ViewBag.lastSkill = db.TBL_Skill.OrderByDescending(x => x.SkillID).Select(x => x.SkillName).FirstOrDefault();
            ViewBag.lastMessage = db.TBL_Message.OrderByDescending(x => x.MessageID).Select(x => x.MessageContent).FirstOrDefault();



            return View();
        }
    }
}