using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using COVID19TriC.Data;
using COVID19TriC.Models;

namespace COVID19TriC.Controllers
{
    public class HomeController : Controller
    {
        private COVID19TriCContext db = new COVID19TriCContext();
        public ActionResult Index(string caseStatus, string QuarantinedFlag)
        {
            var StatusList = new List<COVID19TriC.Models.Status>();

            var StatusQry = from s in db.Status
                            orderby s.StatusID
                            select s;

            StatusList = StatusQry.ToList();
            ViewBag.caseStatus = new SelectList(StatusList, "StatusID", "StatusDescription");

            var cases = from c in db.Cases
                        .Include(p => p.Person)
                        .Include(s => s.Status)
                        select c;

            //if (!String.IsNullOrEmpty(searchString))
            //{
            //    movies = movies.Where(s => s.Title.Contains(searchString));
            //}
            if (QuarantinedFlag == "1")
            {
                cases = cases.Where(x => x.Quarantined == true);
            }
            if (!string.IsNullOrEmpty(caseStatus))
            {
                var CaseStatusID = Int32.Parse(caseStatus);
                cases = cases.Where(x => x.StatusID == CaseStatusID);
            }

            return View(cases.ToList());
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
        public ActionResult DisplayStatsChart()
        {
            return View();
        }
    }
}