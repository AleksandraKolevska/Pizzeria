using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pizzeria.Models;

namespace Pizzeria.Controllers
{
    public class RegistracijaController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            PizzeriaEntities db = new PizzeriaEntities();
            return View();
        }
        public ActionResult SaveRecord(Korisnici model)
        {
            try
            {
                PizzeriaEntities db = new PizzeriaEntities();

                Korisnici kor = new Korisnici();
                kor.Ime = model.Ime;
                kor.Prezime = model.Prezime;
                kor.Email = model.Email;
                kor.Password = model.Password;
                kor.Grad = model.Grad;
                kor.KorisniciID = model.KorisniciID;
                kor.Adresa = model.Adresa;
                kor.Godini = model.Godini;
                kor.Username = model.Username;

                db.Korisnicis.Add(kor);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Index");
        }
    }
}