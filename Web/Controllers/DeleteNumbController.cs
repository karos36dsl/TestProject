using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class DeleteNumbController : Controller
    {
        ApplicationDbContext Db = new ApplicationDbContext();
        public ActionResult Delete(int id)
        {
            Number On = Db.Numbers.Find(id);
            
            
            if (On != null)
            {
                Db.Numbers.Remove(On);
                Db.SaveChanges();
            }
            return View();
        }
    }
}