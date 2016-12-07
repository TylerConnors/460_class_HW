using Final460.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Final460.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Home()
        {
            return View();
        }

        private MyContext db = new MyContext();

        public ActionResult ArtWorkList()
        {
            return View(db.ArtWorks.ToList());
        }
        public ActionResult ClassificationList()
        {
            return View(db.Classifications.ToList());
        }
        public ActionResult ArtistList()
        {
            return View(db.Artists.ToList());
        }
    }
}