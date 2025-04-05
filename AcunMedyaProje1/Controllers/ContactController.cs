using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProje1.Models;

namespace AcunMedyaProje1.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        DBAcunmedyaAkademiEntities2 db = new DBAcunmedyaAkademiEntities2 ();
        public ActionResult Index()
        {
            var values = db.TBL_Contact.ToList ();
            return View(values);
        }

        public ActionResult DeleteContact(int id)
        {
            var values = db.TBL_Contact.Find(id);
            db.TBL_Contact.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult CreateContact()
        {
            return View();
        }

        [HttpPost] 
        public ActionResult CreateContact(TBL_Contact contact)
        {
            db.TBL_Contact.Add(contact);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateContact(int id)
        {
            var value = db.TBL_Contact.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateContact(TBL_Contact model)
        {
            var value = db.TBL_Contact.Find(model.ContactID);
            value.Description = model.Description;
            value.Adress = model.Adress;
            value.Email = model.Email;
            value.Phone = model.Phone;
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}