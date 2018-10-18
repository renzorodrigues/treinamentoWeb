using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TreinamentoWeb.Models.Entity;
using System.Web.Mvc;

namespace TreinamentoWeb.Controllers
{
    public class LoginController : Controller
    {
        private readonly MybdEntities  db = new MybdEntities();

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Login(users user)
        {
            
            if (ModelState.IsValid)
            {
                var usuario = db.users.SingleOrDefault(u => u.email == user.email && u.password == user.password);
                if (usuario != null)
                {
                    Session["user"] = user;
                    return RedirectToAction("Index", "Users");
                }
            }
            return RedirectToAction("Index");
        }
    }
}