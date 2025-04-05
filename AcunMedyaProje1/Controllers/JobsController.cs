using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProje1.Models;

namespace AcunMedyaProje1.Controllers
{
    public class JobsController : Controller
    {
        // GET: Jobs
        DBAcunmedyaAkademiEntities2 db = new DBAcunmedyaAkademiEntities2();
        public ActionResult Index()
        {
            var values = db.TBL_Job.ToList();
            return View(values);
        }
        public ActionResult DeleteJob(int id)
        {
            var values = db.TBL_Job.Find(id);
            db.TBL_Job.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreateJob()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateJob(TBL_Job job)
        {
            db.TBL_Job.Add(job);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateJob(int id)
        {
            var value = db.TBL_Job.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateJob(TBL_Job model)
        {
            var value = db.TBL_Job.Find(model.JobID);
            value.Title = model.Title;
            value.CompanyName = model.CompanyName;
            value.StartDate = model.StartDate; 
            value.EndDate = model.EndDate;
            value.Description = model.Description;
            db.SaveChanges();
            return RedirectToAction("Index");

        } 


    }
}