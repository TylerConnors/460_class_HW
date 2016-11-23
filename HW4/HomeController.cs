using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Web;
using System.Web.Mvc;
using _460HW4.Models;

namespace _460HW4
{
	public class HomeController : Controller
	{
		// GET: Home
		public ViewResult Index()
		{
			return View();
		}
		[HttpGet]
		public ActionResult Page1()
		{
			Debug.WriteLine(Request.RawUrl);
			Debug.WriteLine(Request.HttpMethod);
			Debug.WriteLine(Request.QueryString);
			String num1 = Request.QueryString["itemA"];
			String num2 = Request.QueryString["itemB"];
			ViewBag.data = mixString(num1, num2); //sets the message to the mixed string
			return View();
		}
        [HttpGet]
        public ActionResult Page2()
        {
            Debug.WriteLine("In GET Page2");
            ShowRequest();
            return View();
        }

        [HttpPost]
        public ActionResult Page2(FormCollection form)
        {
            Debug.WriteLine("In POST Page2");
            ShowRequest();
            Debug.WriteLine("firstname = " + form["firstname"]);
            Debug.WriteLine("lastname = " + form["lastname"]);
            ViewBag.message = "Welcome " + form["firstname"]+ " " + form["lastname"] + "!";
            return View();
        }

		public string mixString(string num1, string num2)
		{
			string combined = num1 + num2;
			char[] temp = combined.ToCharArray();
			Random rnd = new Random();
			temp = temp.OrderBy(f => rnd.Next()).ToArray();
			string done = new string(temp);
		    return done;
		}

        [HttpGet]
        public ActionResult Page3()
        {
            Debug.WriteLine("In GET Page3");
            ShowRequest();
            return View();
        }

        [HttpPost]
        public ActionResult Page3(FormCollection form, loanInput loanStyle)
        {
            if (ModelState.IsValid)
            {
                double princ, inter;
                int month;
                if (double.TryParse(form["principal"], out princ))
                {
                    if (double.TryParse(form["interest"], out inter))// 108 means an 8% interest rate
                    {
                       
                        if (Int32.TryParse(form["months"], out month))
                        {
                            double monthly = calculateLoanMonthly(princ, inter, month);
                            @ViewBag.message = "Your Monthly Costs Will Be " + monthly + " Dollars A Month.";
                            return View(loanStyle);
                        }
                        else
                        {
                            @ViewBag.message = "Months is not an int.";
                            return View();
                        }
                    }
                    else
                    {
                        @ViewBag.message = "Interest is not a double.";
                        return View();
                    }
                }
                else
                { 
                    @ViewBag.message = "Principal is not a double.";
                    return View();
                } 
                
            }
            else
            {
                // there is a validation error
                @ViewBag.message = "All fields must be used.";
                return View();
            }
        }

        public double calculateLoanMonthly(double interest, double principal, int months)
        {
            if(interest == 0|| principal == 0 || months == 0)
            {
                return -1;
            }
            double rate = interest / 1200;
            double monthly = rate > 0 ? ((rate + rate / (Math.Pow(1 + rate, months) - 1)) * principal) : principal / months; //made by Leonardo Paneque
            return monthly;
        }


        public void ShowRequest()
		{
			Debug.WriteLine("\t" + Request.RawUrl);
			Debug.WriteLine("\t" + Request.HttpMethod);
			// See if there is form data
			Debug.WriteLine("\tForm Data:");
			NameValueCollection d = Request.Form;
			foreach (string key in d.AllKeys)        // AllKeys returns an empty string array if d is empty
			{
				Debug.WriteLine("\t {0} : {1}", key, d[key]);
			}
		}
	}
}
 