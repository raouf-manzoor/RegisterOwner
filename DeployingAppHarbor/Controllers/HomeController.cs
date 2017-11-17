using DeployingAppHarbor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeployingAppHarbor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            RegisterOwnerEntities dbContext = new RegisterOwnerEntities();
            dbContext.Users.Add(new User()
                {
                    Email = "Raouf@yahoo.com",
                    FirstName = "Raouf",
                    Password = "1234"

                });
            dbContext.SaveChanges();
            return View();
        }
    }
}
