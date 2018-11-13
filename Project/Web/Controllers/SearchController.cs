using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class SearchController : Controller
    {
        AnnonContext Db = new AnnonContext();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string Name,string Price)
        {

            IEnumerable<Annon> annons = Db.Annons.Where(x => x.Name.StartsWith(Name) && x.Price.StartsWith(Price));

            return View(annons);
        }
    }
}