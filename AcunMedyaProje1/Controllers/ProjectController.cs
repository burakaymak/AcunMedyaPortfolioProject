using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProje1.Models;

namespace AcunMedyaProje1.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        DBAcunmedyaAkademiEntities2 db = new DBAcunmedyaAkademiEntities2();
        public ActionResult Index()
        {
            var values = db.TBL_Project.ToList();   
            return View(values);
        }

        public ActionResult DeleteProject(int id)
        {
            var values = db.TBL_Project.Find(id);
            db.TBL_Project.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");   
        }

        [HttpGet] 
        public ActionResult CreateProject()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateProject(TBL_Project project)
        {
            db.TBL_Project.Add(project);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateProject(int id)
        {
            var value = db.TBL_Project.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateProject(TBL_Project model)
        {
            var value = db.TBL_Project.Find(model.ProjectID);
            value.ProjectName = model.ProjectName;
            value.ProjectLink = model.ProjectLink;
            value.Description = model.Description;
            value.Image1 = model.Image1;
            value.Image2 = model.Image2;
            value.Image3 = model.Image3;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}