using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pizzeria.Models;
using System.Web.Script.Serialization;

namespace Pizzeria.Controllers
{   [HandleError]
    public class NarackaController : Controller
    {
        PizzeriaEntities db;
      public NarackaController()
        {
            db = new PizzeriaEntities();
        }

        public ActionResult Index()
        {
           
            ViewData.Model = db.Tips.ToList();
            ViewData.Model = db.Korisnicis.ToList();

            var tip = (from t in db.Tips select t.ImePica).ToList();
            var golemina = (from v in db.Velicinas select v.Golemina).ToList();
           
            List<Object> obj = new List<Object>();
            obj.Add(tip);
            obj.Add(golemina);
            
            ViewData.Model = obj;
                return View();
        }

        public int Kolicina(String tipId, String goleminaId)
        {
            var tipIDs = Int32.Parse(tipId);
            var velicinaID = Int32.Parse(goleminaId);
            var cena = (from c in db.PoedinecnaPicas where c.TipID == tipIDs && c.VelicinaID == velicinaID select c.Cena).ToList().FirstOrDefault();
            int izvlecenaCena = Convert.ToInt32(cena);
            return izvlecenaCena;
        }

        public ActionResult SaveRecord(int tipId, int goleminaId, int kolicinaVk, int userID, string username)
        {
            var user = (from u in db.Korisnicis where u.KorisniciID == userID select u.KorisniciID).ToString();
            if(user ==null)
            {
                Korisnici korisnici = new Korisnici();
                korisnici.KorisniciID = userID;
                korisnici.Username = username;

                db.Korisnicis.Add(korisnici);
                db.SaveChanges();
            }

            try
            {
                Naracka naracka = new Naracka();
                naracka.KorisniciID = userID;
                naracka.VelicinaID = goleminaId;
                naracka.TipID = tipId;
                naracka.Kolicina = kolicinaVk;

                db.Narackas.Add(naracka);
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