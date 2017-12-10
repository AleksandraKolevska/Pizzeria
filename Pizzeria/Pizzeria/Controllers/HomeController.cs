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
            ViewData.Model = pizzaEntity.Kategoriis.ToList();
            ViewData.Model = (from k in pizzaEntity.Kategoriis select k);
        
            return View();
        }

    
    }
}