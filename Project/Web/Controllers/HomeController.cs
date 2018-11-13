using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        AnnonContext Db = new AnnonContext();
        public ActionResult Index ()
        {
            IEnumerable<Annon> annons = Db.Annons;
            ViewBag.Annons = annons;
            
            
            return View();
        }

        

        [HttpGet]
        public ActionResult Respond2(int id)
        {
            ViewBag.AnnonId = id;
            return View();
        }
        [HttpPost]
        public ActionResult Respond2 (Respond respond)
        {
            if (ModelState.IsValid)
            {
                Db.Responds.Add(respond);
                // сохраняем в бд все изменения
                Db.SaveChanges();
                // return "Спасибо," + " "+respond.Name +" "+ "мы рассмотрим вашу заявку и свяжемся с вами в ближайшее время !";
                return View("Message2");
            }
            else
            {
                return View(respond);
            }
        }
    }
}