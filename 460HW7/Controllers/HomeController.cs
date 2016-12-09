using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;


namespace _460HW7.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult StockGraph(string id, bool radio)
        {
            if (id == null)
            {
                id = "MSFT";
            }
            var link = $"http://chart.finance.yahoo.com/table.csv?s={id}&a=10&b=8&c=2016&d=11&e=8&f=2016&g=d&ignore=.csv";
            var getCompany = $"http://finance.yahoo.com/d/quotes.csv?s={id}&f=sn";
           
            //make a Request to the URL than get the response. 		
            WebRequest request = WebRequest.Create(link);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //get the stream that has the content from the server and open it with a reader
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            //put it all into a string so it can be used later 
            string responseFromServer = reader.ReadToEnd();

            //make a Request to the URL than get the response. 		
            WebRequest request2 = WebRequest.Create(getCompany);
            HttpWebResponse response2 = (HttpWebResponse)request2.GetResponse();
            //get the stream that has the content from the server and open it with a reader
            Stream responseStream2 = response2.GetResponseStream();
            StreamReader reader2 = new StreamReader(responseStream2);
            //put it all into a string so it can be used later 
            string responseFromServer2 = reader2.ReadToEnd();

            //Close everything since it's all done
            reader.Close();
            responseStream.Close();
            response.Close();

            //Close everything since it's all done
            reader2.Close();
            responseStream2.Close();
            response2.Close();

            var data = new
            {
                Pagelink = responseFromServer,
                Symbol = id,
                Company = responseFromServer2,
                ShowCompany = radio
            };

            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}