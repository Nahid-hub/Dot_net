using Project.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Controllers
{
    public class HotelController : Controller
    {
        // GET: Hotel
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(Registration r)
        {
            if(ModelState.IsValid){
                ProjectEntities db = new ProjectEntities();
                db.Registrations.Add(r);
                db.SaveChanges();
                return RedirectToAction("Login");

            }
            return View();
        }
    }

    public class Hotel
    {
    }
}