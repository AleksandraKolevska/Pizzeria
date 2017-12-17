using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pizzeria.Models;

namespace Pizzeria.Controllers
{
    [HandleError]
    public class MeniController : Controller
    {
        PizzeriaEntities db;
        // GET: Meni
        public MeniController()
        {
            db = new PizzeriaEntities();
        }
        public ActionResult Index()
        {
            ViewData.Model = db.PoedinecnaPicas.ToList();
            var obj = (from b in db.PoedinecnaPicas 
                       select new {b.OpisID, b.TipID, b.VelicinaID}).ToList();
            return View();
        }
        public ActionResult SaveRecord( int opis,int tip,int velicina)
        {
            try
            {
                PizzeriaEntities db = new PizzeriaEntities();

                Meni meni = new Meni();
                meni.TipID = tip;
                meni.OpisID = opis;
                meni.VelicinaID = velicina;

                db.Menis.Add(meni);
                db.SaveChanges();
            }catch(Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Index");
        }
    }
}