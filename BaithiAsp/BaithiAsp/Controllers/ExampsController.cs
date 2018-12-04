using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BaithiAsp.Context;
using BaithiAsp.Models;

namespace BaithiAsp.Controllers
{
    public class ExampsController : Controller
    {
        private ExampContext db = new ExampContext();

        // GET: Examps
        public ActionResult Index()
        {
            return View(db.Examps.ToList());
        }

        // GET: Examps/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Examp examp = db.Examps.Find(id);
            if (examp == null)
            {
                return HttpNotFound();
            }
            return View(examp);
        }

        // GET: Examps/Create
        public ActionResult Create()
        {
            List<Subject> subjects = new List<Subject>()
{
new Subject{ Name="Core Java", Id = 1 },
new Subject{ Name="Advance Java", Id = 2 },
new Subject{ Name="Programing C#", Id = 3 },

};
            ViewBag.subjectList = subjects;
            return View();
        }

        // POST: Examps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Subject,StartTime,ExamTime,Duration,ClassRomm,Faculty,Status")] Examp examp)
        {
            if (ModelState.IsValid)
            {
                db.Examps.Add(examp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(examp);
        }

        // GET: Examps/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Examp examp = db.Examps.Find(id);
            if (examp == null)
            {
                return HttpNotFound();
            }
            return View(examp);
        }

        // POST: Examps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Subject,StartTime,ExamTime,Duration,ClassRomm,Faculty,Status")] Examp examp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(examp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(examp);
        }

        // GET: Examps/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Examp examp = db.Examps.Find(id);
            if (examp == null)
            {
                return HttpNotFound();
            }
            return View(examp);
        }

        // POST: Examps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Examp examp = db.Examps.Find(id);
            db.Examps.Remove(examp);
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
