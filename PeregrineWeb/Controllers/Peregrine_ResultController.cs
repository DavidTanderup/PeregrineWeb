using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PeregrineWeb.Models;

namespace PeregrineWeb.Controllers
{
    public class Peregrine_ResultController : Controller
    {
        private PeregrineResearchDatabaseEntities db = new PeregrineResearchDatabaseEntities();

        // GET: Peregrine_Result
        public ActionResult Index()
        {
            return View(db.Peregrine_Results.ToList());
        }

        // GET: Peregrine_Result/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Peregrine_Result peregrine_Result = db.Peregrine_Results.Find(id);
            if (peregrine_Result == null)
            {
                return HttpNotFound();
            }
            return View(peregrine_Result);
        }

        // GET: Peregrine_Result/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Peregrine_Result/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Date,CIK,Symbol,Last_Close,C50_Day_Avg,Name,Address_1,Address_2,City___State,Phone,SIC,Industry,MACD,MACD_Signal,Stochastic_Slow,Stochastic_Signal")] Peregrine_Result peregrine_Result)
        {
            if (ModelState.IsValid)
            {
                db.Peregrine_Results.Add(peregrine_Result);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(peregrine_Result);
        }

        // GET: Peregrine_Result/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Peregrine_Result peregrine_Result = db.Peregrine_Results.Find(id);
            if (peregrine_Result == null)
            {
                return HttpNotFound();
            }
            return View(peregrine_Result);
        }

        // POST: Peregrine_Result/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Date,CIK,Symbol,Last_Close,C50_Day_Avg,Name,Address_1,Address_2,City___State,Phone,SIC,Industry,MACD,MACD_Signal,Stochastic_Slow,Stochastic_Signal")] Peregrine_Result peregrine_Result)
        {
            if (ModelState.IsValid)
            {
                db.Entry(peregrine_Result).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(peregrine_Result);
        }

        // GET: Peregrine_Result/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Peregrine_Result peregrine_Result = db.Peregrine_Results.Find(id);
            if (peregrine_Result == null)
            {
                return HttpNotFound();
            }
            return View(peregrine_Result);
        }

        // POST: Peregrine_Result/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Peregrine_Result peregrine_Result = db.Peregrine_Results.Find(id);
            db.Peregrine_Results.Remove(peregrine_Result);
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
