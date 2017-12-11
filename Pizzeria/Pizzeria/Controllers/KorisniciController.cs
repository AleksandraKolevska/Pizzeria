using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pizzeria.Models;


namespace Pizzeria.Controllers
{
    public class KorisniciController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult RegistrationForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RegistrationForm( Korisnici registration )
        { 
            return View("Congratulation",registration);
        }
    }
}