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
        public JsonResult Gimme(int actor)
        {
            //get the data from the server

            var credits = from AllCasts in db.AllCasts
           join Movies in db.Movies on AllCasts.MovieID equals Movies.MovieID
           where AllCasts.ActorID == actor
           select new { Title = AllCasts.Movie.Title, DirectorName = AllCasts.Movie.Director.Name };

            return Json(credits.ToList(), JsonRequestBehavior.AllowGet);
        }
    }
}