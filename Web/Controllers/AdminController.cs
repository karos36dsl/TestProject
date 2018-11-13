using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class AdminController : Controller
    {
        ApplicationDbContext Db = new ApplicationDbContext();
        public ActionResult Admin()
        {
            string a = User.Identity.GetUserName();
            if (a != "Admin@mail.ru")
            {
                return View("Error3");
            }
            return View();
        }

        public ActionResult AllUsers()
        {
            IEnumerable<ApplicationUser> users = Db.Users;
            ViewBag.Users = users;
            return View();
            
        }
        [HttpGet]
        public ActionResult AddNumber()
        {
            IEnumerable<Number> numbers = Db.Numbers;
            ViewBag.Numbers = numbers;
            return View();

        }
        [HttpPost]
        public ActionResult AddNumber(Number number)
        {
            if (ModelState.IsValid)
            {
                Db.Numbers.Add(number);
                Db.SaveChanges();
                return View("Message4");
            }
            else
            {
                return View(number);
            }

        }

        public ActionResult AdminNumber()
        {
            IEnumerable<Number> numbers = Db.Numbers;
            ViewBag.Numbers = numbers;
            return View();

        }

        public ActionResult AllOrderNumbers()
        {
            IEnumerable<OrderNumber> Ordernumbers = Db.OrderNumbers;
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


    }
}