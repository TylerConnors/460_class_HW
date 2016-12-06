using _460HW8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace _460HW8.Controllers
{
    public class BootyController : Controller
    {

        private MyPiratesContext db = new MyPiratesContext();

        // GET: Booty
        public ActionResult Booty()
        {
            return View();
        }


        public JsonResult Gimme()
        {
            //get the data from the server
            var totals = db.Pirates.Select(p => new { FirstName = p.FirstName, LastName = p.LastName, Booty = p.Crews.Select(c => c.Booty).DefaultIfEmpty(0).Sum() }).OrderByDescending(pnb => pnb.Booty).ToList();
            //give back the json file to work with
			return Json(totals, JsonRequestBehavior.AllowGet);
        }
    }
}