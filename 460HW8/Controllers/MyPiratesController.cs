using _460HW8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace _460HW8.Controllers
{
    public class MyPiratesController : Controller
    {
        // GET: Home
        public ActionResult Home()
        {
            return View();
        }

        private MyPiratesContext db = new MyPiratesContext();
		// GET: Ship
        public ActionResult ShipList()
        {
            return View(db.Ships.ToList());
        }
		// GET: Crew
        public ActionResult CrewList()
        {
            return View(db.Crews.ToList());
        }
		// GET: Booty
        public ActionResult Booty()
        {
            return View();
        }
    }
}