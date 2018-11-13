using Microsoft.AspNet.Identity;
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

        ApplicationDbContext Db = new ApplicationDbContext();
        public ActionResult AllNumbers()
        {
            IEnumerable<Number> numbers = Db.Numbers;
            ViewBag.Numbers = numbers;
            return View();
        }
       
        public ActionResult LiveNumber()
        {

            string a = User.Identity.GetUserName();
            if (a == "")
            {
                return View("Error2");
            }




            //string a = User.Identity.GetUserName();
            IEnumerable<OrderNumber> Ordernumbers = Db.OrderNumbers.Where(x => x.UserId.StartsWith(a));
            ViewBag.OrderNumbers = Ordernumbers;
            return View();
        }
        
        public ActionResult EndLiveNumber(int id)
        {
            OrderNumber On = Db.OrderNumbers.Find(id);
            Number n = Db.Numbers.Find(On.NumberId);





            var price = On.EndDate.Subtract(On.BeginDate);
            ViewBag.price = price;



            if (n != null)
            {
                n.Status = "Свободен";
                Db.SaveChanges();
            }

            if (On != null)
            {
                Db.OrderNumbers.Remove(On);
                Db.SaveChanges();
            }
            return View();
        }


        [HttpGet]
        public ActionResult OrderNumber(int id)
        {
            Number n = Db.Numbers.Find(id);

            string a = User.Identity.GetUserName();
            if (a == "")
            {
                return View("Error2");
            }



            if (n != null)
            {
                if (n.Status == "Номер Занят")
                    return View("Error");
            }

            ViewBag.NumberId = id;
            ViewBag.UserId = User.Identity.GetUserName();
            return View();
        }


        [HttpPost]
        public ActionResult OrderNumber(OrderNumber orderNumber)
        {
            Number n = Db.Numbers.Find(orderNumber.NumberId);
            if (n != null)
            {
                n.Status = "Номер Занят";
                Db.SaveChanges();
            }
            if (ModelState.IsValid)
            {
                Db.OrderNumbers.Add(orderNumber);
                Db.SaveChanges();
                return View("Message");
            }
            else
            {
                return View(orderNumber);
            }
        }


        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Сайт по оформлению номеров в отеле Онлайн";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Ваша Контактная страница";

            return View();
        }
    }
}