using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProje1.Models;
using Microsoft.Ajax.Utilities;

namespace AcunMedyaProje1.Controllers
{
    public class SliderController : Controller
    {
        // GET: Slider
        DBAcunmedyaAkademiEntities2 db = new DBAcunmedyaAkademiEntities2();
        public ActionResult Index()
        {
            var values = db.TBL_Slider.ToList();
            return View(values);
        }

        public ActionResult DeleteSlider(int id)
        {
            var values = db.TBL_Slider.Find(id);
            db.TBL_Slider.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateSlider()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateSlider(TBL_Slider slider)
        {
            db.TBL_Slider.Add(slider);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateSlider(int id)
        {
            var value = db.TBL_Slider.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateSlider(TBL_Slider model)
        {
            var value = db.TBL_Slider.Find(model.SliderID);
            value.NameSurname = model.NameSurname;
            value.Description = model.Description;
            value.ImageUrl = model.ImageUrl;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}