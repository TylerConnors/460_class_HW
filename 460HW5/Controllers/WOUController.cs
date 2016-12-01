using _460HW5.DAL;
using _460HW5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Web;
using System.Web.Mvc;

namespace _460HW5.Controllers
{
    public class WOUController : Controller
    {
        private WOUContext db = new WOUContext();
        
        // GET: WOU
        public ActionResult Index()
        {
            return View(db.WOUForms.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(WOUForm Change)
        {
            if (ModelState.IsValid)
            {
                Debug.WriteLine("ChangeReq in Create [POST]: " + Change);
                db.WOUForms.Add(Change);
                db.SaveChanges();
                return RedirectToAction("Index");   
            }
            return View(Change);
        }

    }

}