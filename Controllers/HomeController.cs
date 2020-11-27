using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Helpers;

namespace COVID19TriC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        public ActionResult Graph()
        {
            string[] _xval = { "6/5/2020", "6/13/2020", "6/20/2020", "6/27/2020", "7/5/2020", "7/5/2020", "7/5/2020", "7/5/2020", "8/5/2020", "8/5/2020", "8/5/2020", "8/5/2020", "9/5/2020", "9/5/2020", "9/5/2020" };
            string[] _yval = { "23", "22", "20", "26", "30", "32", "30", "32", "40", "45", "47", "52", "68", "76", "89" };
            //here the chart is going on
            var bytes = new Chart(width: 900, height: 300)
            .AddSeries(
            chartType: "Line", legend: "Mindcracker Current Month Runner up", 
             xValue: _xval,
             yValues: _yval)
            .GetBytes("png");
            return File(bytes, "image/png");
        }
        
    }

}