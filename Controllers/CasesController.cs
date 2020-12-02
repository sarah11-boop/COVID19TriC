using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using COVID19TriC.Models;
using COVID19TriC.Data;




namespace COVID19TriC.Controllers
{
    
    public class CasesController : Controller
    {

        private COVID19TriCContext db = new COVID19TriCContext();
        // GET: Cases
        public ActionResult Index(string caseStatus, string QuarantinedFlag, string SearchString)
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
                        .Include(d => d.Department)
                        .Include(l => l.Location)
                        select c;

            if (!String.IsNullOrEmpty(SearchString))
            {
               cases = cases.Where(n => n.Person.LastName.Contains(SearchString));
            }
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

        // GET: Cases/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                var cases = from c in db.Cases
                       .Include(p => p.Person)
                       .Include(s => s.Status)
                       .Include(d => d.Department)
                        select c;

                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Case @case = db.Cases.Find(id);
            if (@case == null)
            {
                return HttpNotFound();
            }
            return View(@case);
        }

        // GET: Cases/Create
        public ActionResult Create()
        {
            var StatusList = new List<COVID19TriC.Models.Status>();
            var StatusQry = from s in db.Status
                            orderby s.StatusID
                            select s;
            StatusList = StatusQry.ToList();
            ViewBag.caseStatus = new SelectList(StatusList, "StatusID", "StatusDescription");

            var DepartmentList = new List<COVID19TriC.Models.Department>();
            var DepartmentQry = from s in db.Departments
                                orderby s.DepartmentID
                                select s;
            DepartmentList = DepartmentQry.ToList();
            ViewBag.departmentStatus = new SelectList(DepartmentList, "DepartmentID", "DepartmentDescription");
            return View();
        }
        // POST: Cases/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CaseID,Quarantined,DateQuarantineEnds,CountyNotified,GeneralComments,ExposureComments,DateLastAtLocation,DateOfExposure,DateOfSymptoms,DateOfTest,DateOfDiagnosis,DateReported,Symptoms,ReportingName,ReportingTitle,DateCreated,DateModified,CreatedBy,ModifiedBy,ReportingDepartmentID,TravelRestrictionState,StatusID,PersonID")] Case @case)
        {
            if (ModelState.IsValid)
            {
                db.Cases.Add(@case);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(@case);
        }
              public ActionResult Create()
        {
            var StatusList = new List<COVID19TriC.Models.Status>();
            var StatusQry = from s in db.Status
                            orderby s.StatusID
                            select s;
            StatusList = StatusQry.ToList();
            ViewBag.caseStatus = new SelectList(StatusList, "StatusID", "StatusDescription");

            var DepartmentList = new List<COVID19TriC.Models.Department>();
            var DepartmentQry = from s in db.Departments
                                orderby s.DepartmentID
                                select s;
            DepartmentList = DepartmentQry.ToList();
            ViewBag.departmentStatus = new SelectList(DepartmentList, "DepartmentID", "DepartmentDescription");
            return View();
        }
   
       

        // GET: Cases/Edit/5
        public ActionResult Edit(int? id)
        {
            var StatusList = new List<COVID19TriC.Models.Status>();
            var StatusQry = from s in db.Status
                            orderby s.StatusID
                            select s;
            StatusList = StatusQry.ToList();
            ViewBag.caseStatus = new SelectList(StatusList, "StatusID", "StatusDescription");

            var DepartmentList = new List<COVID19TriC.Models.Department>();
            var DepartmentQry = from s in db.Departments
                                orderby s.DepartmentID
                                select s;
            DepartmentList = DepartmentQry.ToList();
            ViewBag.departmentStatus = new SelectList(DepartmentList, "DepartmentID", "DepartmentDescription");

           
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Case @case = db.Cases.Find(id);
            if (@case == null)
            {
                return HttpNotFound();
            }
            return View(@case);
        }

        // POST: Cases/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CaseID,Quarantined,DateQuarantineEnds,CountyNotified,GeneralComments,ExposureComments,DateLastAtLocation,DateOfExposure,DateOfSymptoms,DateOfTest,DateOfDiagnosis,DateReported,Symptoms,ReportingName,ReportingTitle,DateCreated,DateModified,CreatedBy,ModifiedBy,ReportingDepartmentID,TravelRestrictionState,StatusID,PersonID")] Case @case)
        {
            if (ModelState.IsValid)
            {
                db.Entry(@case).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(@case);
        }
        public ActionResult Edit(int? id)
        {
            var StatusList = new List<COVID19TriC.Models.Status>();
            var StatusQry = from s in db.Status
                            orderby s.StatusID
                            select s;
            StatusList = StatusQry.ToList();
            ViewBag.caseStatus = new SelectList(StatusList, "StatusID", "StatusDescription");

            var DepartmentList = new List<COVID19TriC.Models.Department>();
            var DepartmentQry = from s in db.Departments
                                orderby s.DepartmentID
                                select s;
            DepartmentList = DepartmentQry.ToList();
            ViewBag.departmentStatus = new SelectList(DepartmentList, "DepartmentID", "DepartmentDescription");

        // GET: Cases/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Case @case = db.Cases.Find(id);
            if (@case == null)
            {
                return HttpNotFound();
            }
            return View(@case);
        }

        // POST: Cases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Case @case = db.Cases.Find(id);
            db.Cases.Remove(@case);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
