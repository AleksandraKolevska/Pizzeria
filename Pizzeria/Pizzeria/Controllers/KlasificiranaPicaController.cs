using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pizzeria.Models;

namespace Pizzeria.Controllers
{
        public class KlasificiranaPicaController : Controller
        {
            PizzeriaEntities pizzaEntity;

            public KlasificiranaPicaController()
            {
                pizzaEntity = new PizzeriaEntities();
            }
            public ActionResult KlasaPica()
            {
          ViewData.Model = pizzaEntity.PoedinecnaPicas.ToList();
            var obj = (from o in pizzaEntity.PoedinecnaPicas select o);
                             
            return View();
        }
        public ActionResult Vegetarijana()
        {
            ViewData.Model = pizzaEntity.PoedinecnaPicas.ToList();
            var obj = (from o in pizzaEntity.PoedinecnaPicas select o);

            return View();
        }
        public ActionResult Posna()
        {
            ViewData.Model = pizzaEntity.PoedinecnaPicas.ToList();
            var obj = (from o in pizzaEntity.PoedinecnaPicas select o);

            return View();
        }
        public ActionResult MeniPici1()
        {
            ViewData.Model = pizzaEntity.PoedinecnaPicas.ToList();
            var obj = (from o in pizzaEntity.PoedinecnaPicas select o);

            return View();
        }



    }
}