using ForumApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ForumApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ViewResult FAQ()
        {
            //ViewBag.Message = "Frequently ask question any time.";
            ViewBag.Country = new List<string>()
            {
                "India",
                "USA",
                "UK",
                "UAE"
            };

            return View();    
        }

        public ActionResult MyCustomPage()
        {
            var model = new UserModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult MyCustomPage(UserModel user)
        {
            user.StatusMessage = "Recieved and saved.";
            return View(user);
            //return Content("Received Username:" + user.username + " Age:" + user.age);
        }
    }
}
