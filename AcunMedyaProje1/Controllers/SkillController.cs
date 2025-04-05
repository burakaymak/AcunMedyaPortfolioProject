using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProje1.Models;
using Microsoft.Ajax.Utilities;

namespace AcunMedyaProje1.Controllers
{
    public class SkillController : Controller
    {
        // GET: Skill
        DBAcunmedyaAkademiEntities2 db = new DBAcunmedyaAkademiEntities2();
        public ActionResult Index()
        {
            var values = db.TBL_Skill.ToList();
            return View(values);
        }

        public ActionResult DeleteSkill(int id)
        {
            var values = db.TBL_Skill.Find(id);
            db.TBL_Skill.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateSkill()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateSkill(TBL_Skill skill)
        {
            db.TBL_Skill.Add(skill);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateSkill(int id)
        {
            var value = db.TBL_Skill.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateSkill(TBL_Skill model)
        {
            var value = db.TBL_Skill.Find(model.SkillID);
            value.SkillName = model.SkillName;
            value.Derece = model.Derece;
            value.Description = model.Description;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
    }
}