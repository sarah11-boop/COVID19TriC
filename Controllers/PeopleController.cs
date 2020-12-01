using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using COVID19TriC.Data;
using COVID19TriC.Models;

namespace COVID19TriC.Controllers
{
    public class PeopleController : Controller
    {
        private COVID19TriCContext db = new COVID19TriCContext();

        // GET: People
        public ActionResult Index()
        {
            return View(db.People.ToList());
        }

        // GET: People/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person person = db.People.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        // GET: People/Create
        public ActionResult Create()
        {
            var LocationList = new List<COVID19TriC.Models.Location>();
            var LocationQry = from s in db.Locations
                              orderby s.LocationID
                              select s;
            LocationList = LocationQry.ToList();
            ViewBag.locationStatus = new SelectList(LocationList, "LocationID", "LocationDescription");

            var DepartmentList = new List<COVID19TriC.Models.Department>();
            var DepartmentQry = from s in db.Departments
                                orderby s.DepartmentID
                                select s;
            DepartmentList = DepartmentQry.ToList();
            ViewBag.departmentStatus = new SelectList(DepartmentList, "DepartmentID", "DepartmentDescription");
            return View();
        }
        // POST: People/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PersonID,SNumber,LastName,FirstName,MiddleName,PersonalEmail,SchoolEmail,PhoneNumber,DateCreated,DateModified,CreatedBy,ModifiedBy,DepartmentID,LocationID")] Person person)
        {
            if (ModelState.IsValid)
            {
                db.People.Add(person);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(person);
        }

        // GET: People/Edit/5
        public ActionResult Edit(int? id)
        {
            var LocationList = new List<COVID19TriC.Models.Location>();
            var LocationQry = from s in db.Locations
                              orderby s.LocationID
                              select s;
            LocationList = LocationQry.ToList();
            ViewBag.locationStatus = new SelectList(LocationList, "LocationID", "LocationDescription");

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
            Person person = db.People.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        // POST: People/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PersonID,SNumber,LastName,FirstName,MiddleName,PersonalEmail,SchoolEmail,PhoneNumber,DateCreated,DateModified,CreatedBy,ModifiedBy,DepartmentID,LocationID")] Person person)
        {
            if (ModelState.IsValid)
            {
                db.Entry(person).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(person);
        }

        // GET: People/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person person = db.People.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        // POST: People/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Person person = db.People.Find(id);
            db.People.Remove(person);
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
