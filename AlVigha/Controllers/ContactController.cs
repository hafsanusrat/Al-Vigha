using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AlVigha.Models;

namespace AlVigha.Controllers
{
    public class ContactController : Controller
    {

        AlVighaEntities DB = new AlVighaEntities();

        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendMessage(SiteMessage msg)
        {
            if (ModelState.IsValid)
            {

            SiteMessage obj = new SiteMessage();
            obj.msgName = msg.msgName;
            obj.msgEmail = msg.msgEmail;
            obj.msgSubject = msg.msgSubject;
            obj.msgBody = msg.msgBody;

            DB.SiteMessages.Add(obj);
            DB.SaveChanges();
            }
            ModelState.Clear();

            return View("Index");
        }
    }
}