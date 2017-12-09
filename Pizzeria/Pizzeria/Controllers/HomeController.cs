using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pizzeria.Models;

namespace Pizzeria.Controllers
{
    public class HomeController : Controller
    {
        PizzeriaEntities pizzaEntity;

        public HomeController()
        {
            pizzaEntity = new PizzeriaEntities();
        }
        public ActionResult Index()
        {
            ViewData.Model = pizzaEntity.Tips.ToList();
            ViewData.Model = (from c in pizzaEntity.Tips select c);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}