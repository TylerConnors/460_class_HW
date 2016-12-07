using Final460Take2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Final460Take2.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Home()
        {
            return View();
        }

        private MyMovieContext db = new MyMovieContext();

        public ActionResult ActorList()
        {
            return View(db.Actors.ToList());
        }
        public ActionResult AllCastList()
        {
            return View(db.AllCasts.ToList());
        }
        public ActionResult DirectorList()
        {
            return View(db.Directors.ToList());
        }
    }
}