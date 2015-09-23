using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Camping.Controllers
{
    public class HomeController : Controller
    {
        private object id;

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Connexion()
        {
            return View();
        }

        public ActionResult Inscription()
        {
            return View();
        }
    }
}