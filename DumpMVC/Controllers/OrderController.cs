using DumpMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DumpMVC.Controllers {
    public class OrderController : Controller {
        // GET: Order
        public ActionResult Index() {
            return View();
        }
        public ActionResult Shake() {
            return View();
        }

        public ActionResult Hamburger() {
            Hamburger ham = new Hamburger();
            ham.Bread = Sandwich.Breads.White;
            ham.HasCheese = ham.HasLettuce = ham.HasTomatos = true;
            return View(ham);
        }

        public ActionResult French() {
            return View();
        }


        public ActionResult Fries() {
            return View("French");
        }

        public ActionResult Tots() {
            return View();
        }
    }
}