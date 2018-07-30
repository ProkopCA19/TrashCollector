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
    public class PickupDaysController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PickupDays
        public ActionResult Index()
        {
            return View(db.PickupDays.ToList());
        }

        // GET: PickupDays/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PickupDay pickupDay = db.PickupDays.Find(id);
            if (pickupDay == null)
            {
                return HttpNotFound();
            }
            return View(pickupDay);
        }

        // GET: PickupDays/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PickupDays/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PickupID,Charge,Name")] PickupDay pickupDay)
        {
            if (ModelState.IsValid)
            {
                db.PickupDays.Add(pickupDay);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pickupDay);
        }

        // GET: PickupDays/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PickupDay pickupDay = db.PickupDays.Find(id);
            if (pickupDay == null)
            {
                return HttpNotFound();
            }
            return View(pickupDay);
        }

        // POST: PickupDays/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PickupID,Charge,Name")] PickupDay pickupDay)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pickupDay).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pickupDay);
        }

        // GET: PickupDays/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PickupDay pickupDay = db.PickupDays.Find(id);
            if (pickupDay == null)
            {
                return HttpNotFound();
            }
            return View(pickupDay);
        }

        // POST: PickupDays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PickupDay pickupDay = db.PickupDays.Find(id);
            db.PickupDays.Remove(pickupDay);
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
