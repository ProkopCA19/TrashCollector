using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Trash_Collector.Models;

namespace Trash_Collector.Controllers
{
    public class ZipcodesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Zipcodes
        public ActionResult Index()
        {
            return View(db.Zipcodes.ToList());
        }

        // GET: Zipcodes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zipcode zipcode = db.Zipcodes.Find(id);
            if (zipcode == null)
            {
                return HttpNotFound();
            }
            return View(zipcode);
        }

        // GET: Zipcodes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Zipcodes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ZipcodeId")] Zipcode zipcode)
        {
            if (ModelState.IsValid)
            {
                db.Zipcodes.Add(zipcode);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(zipcode);
        }

        // GET: Zipcodes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zipcode zipcode = db.Zipcodes.Find(id);
            if (zipcode == null)
            {
                return HttpNotFound();
            }
            return View(zipcode);
        }

        // POST: Zipcodes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ZipcodeId")] Zipcode zipcode)
        {
            if (ModelState.IsValid)
            {
                db.Entry(zipcode).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(zipcode);
        }

        // GET: Zipcodes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zipcode zipcode = db.Zipcodes.Find(id);
            if (zipcode == null)
            {
                return HttpNotFound();
            }
            return View(zipcode);
        }

        // POST: Zipcodes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Zipcode zipcode = db.Zipcodes.Find(id);
            db.Zipcodes.Remove(zipcode);
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
