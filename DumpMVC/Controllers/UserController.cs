using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DumpMVC.Controllers {
    public class UserController : Controller {
        // GET: User
        public ActionResult Index() {

            return View();
        }


        public ActionResult Login() {
            ViewBag.Message = "Please Log in.";
            return View();
        }

        //[HttpPost]
        //public ActionResult Login(string UserName, string Password) {
        //    if (UserName == "Bob" && Password == "yes i am") {
        //        return RedirectToAction("Index", "Home");
        //    } else {
        //        ViewBag.Message = "You are not Bob, " + Request.Form["UserName"];
        //        return View();
        //    }
        //}

        [HttpPost]
        public ActionResult Login([Bind(Include = "UserName,Password")] Models.User usr) {
            //if (usr.UserName == "Bob" && usr.Password == "yes i am") {
            //return RedirectToAction("Index", "Home");
            //usr.UserName = "Was Bob";
            Models.User u = Models.DAL.Get(usr.UserName, usr.Password);
            if (u != null) {
                return View("Details", u);
            } else {
                ViewBag.Message = "You are not Bob, " + usr.UserName;
                return View();
            }
        }

    }
}