using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pizzeria.Models;

namespace Pizzeria.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Korisnici objUser)
        {
            if (ModelState.IsValid)
            {
                using (PizzeriaEntities db = new PizzeriaEntities())
                {
                    var obj = db.Korisnicis.Where(a => a.Username.Equals(objUser.Username) && a.Password.Equals(objUser.Password)).FirstOrDefault();
                    //var obj = (from a in db.Kupuvacs where a.username==objUser.username && a.pass==objUser.pass select new {a.KupuvacID,a.username });
                    if (obj != null)
                    {
                        Session["UserID"] = obj.KorisniciID.ToString();
                        Session["UserName"] = obj.Username.ToString();
                        return RedirectToAction("UserDashBoard");
                    }
                }
            }
            return View(objUser);
        }

        public ActionResult UserDashBoard()
        {
            if (Session["UserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}