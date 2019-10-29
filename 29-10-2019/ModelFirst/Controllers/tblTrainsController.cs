using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ModelFirst.Models;

namespace ModelFirst.Controllers
{
    public class tblTrainsController : Controller
    {
        private TrainsDbModelContainer db = new TrainsDbModelContainer();

        // GET: tblTrains
        public ActionResult Index()
        {
            return View(db.tblTrains.ToList());
        }

        // GET: tblTrains/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblTrain tblTrain = db.tblTrains.Find(id);
            if (tblTrain == null)
            {
                return HttpNotFound();
            }
            return View(tblTrain);
        }

        // GET: tblTrains/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tblTrains/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TrainNo,TrainName,Departure,Destination")] tblTrain tblTrain)
        {
            if (ModelState.IsValid)
            {
                db.tblTrains.Add(tblTrain);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblTrain);
        }

        // GET: tblTrains/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblTrain tblTrain = db.tblTrains.Find(id);
            if (tblTrain == null)
            {
                return HttpNotFound();
            }
            return View(tblTrain);
        }

        // POST: tblTrains/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TrainNo,TrainName,Departure,Destination")] tblTrain tblTrain)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblTrain).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblTrain);
        }

        // GET: tblTrains/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblTrain tblTrain = db.tblTrains.Find(id);
            if (tblTrain == null)
            {
                return HttpNotFound();
            }
            return View(tblTrain);
        }

        // POST: tblTrains/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblTrain tblTrain = db.tblTrains.Find(id);
            db.tblTrains.Remove(tblTrain);
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
