using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnitTestDemo.Models;

namespace UnitTestDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Employee emp = new Employee()
            {
                id = 1,
                Name="Chandu"

            };


            return View("Index",emp);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page..";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}