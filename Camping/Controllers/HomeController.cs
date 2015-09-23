using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Camping.Models;

namespace Camping.Controllers
{
    public class HomeController : Controller
    {
        private object id;

        

        // GET: Home
        public ActionResult Index()
        {
            var entities = new CampingEntities();
            return View(entities.Utilisateur.ToList());
        }

        

        public ActionResult Connexion()
        {
            return View();
        }

        public ActionResult Inscription(Utilisateur user)
        {
            if (ModelState.IsValid)
            {
                
            }
            return View();
        }

        // GET: /Home/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Home/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Home/Create

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Home/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Home/Edit/5

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}