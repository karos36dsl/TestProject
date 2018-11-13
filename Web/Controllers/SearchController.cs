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
        ApplicationDbContext Db = new ApplicationDbContext();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string quantityRooms, string typeRoom, string price)
        {
            IEnumerable<Number> numbers = Db.Numbers.Where(x => x.QuantityRooms.StartsWith(quantityRooms) && x.TypeRoom.StartsWith(typeRoom) && x.Price.StartsWith(price));
            return View(numbers);
        }
    }
}