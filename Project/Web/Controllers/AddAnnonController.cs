using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class AddAnnonController : Controller
    {
        AnnonContext Db = new AnnonContext();


        [HttpGet]
        public ActionResult AddAnnon2 ()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAnnon2 (Annon annon)
        {
            if (ModelState.IsValid)
            {

                Db.Annons.Add(annon);
                // сохраняем в бд все изменения
                Db.SaveChanges();
                // return "Спасибо," + " " + annon.ContactFace + " " + "Ваше объявление будет добавлено на сайт";
                return View("Message");
            }
            else
            {
                return View(annon);
            }
        }

    }
}