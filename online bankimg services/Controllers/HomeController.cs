using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using online_bankimg_services.Models;

namespace online_bankimg_services.Controllers
{
    public class HomeController : Controller
    {
        bankingEntities dc = new bankingEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminLogin(admin obj)
        {
            var res = (from t in dc.admins
                       where t.username== obj.username && t.pwd == obj.pwd
                       select t).Count();

            if (res > 0)
            {

                ViewBag.e = "Your Logged in";
            }
            else
            {

                ViewBag.e = "Invalid username and pwd";
            }

            return View();
        }
        public ActionResult transaction()
        {
            return View();
        }

    }
}