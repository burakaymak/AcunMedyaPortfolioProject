using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProje1.Models;

namespace AcunMedyaProje1.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        DBAcunmedyaAkademiEntities2 db = new DBAcunmedyaAkademiEntities2();
        public ActionResult Index()
        {
            var values = db.TBL_Message.ToList();
            return View(values);
        }

        public ActionResult DeleteMessage(int id)
        {
            var values = db.TBL_Message.Find(id);
            db.TBL_Message.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult CreateMessage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateMessage(TBL_Message message)
        {
            db.TBL_Message.Add(message);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateMessage(int id)
        {
            var value = db.TBL_Message.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateMessage(TBL_Message model)
        {
            var value = db.TBL_Message.Find(model.MessageID);
            value.NameSurname = model.NameSurname;
            value.Mail = model.Mail;
            value.Subject = model.Subject;
            model.MessageContent = model.MessageContent;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}