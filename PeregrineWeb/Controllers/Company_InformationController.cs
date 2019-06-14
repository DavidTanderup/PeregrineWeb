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
    public class Company_InformationController : Controller
    {
        Peregrine_Result peregrine = new Peregrine_Result();

        private PeregrineResearchDatabaseEntities db = new PeregrineResearchDatabaseEntities();

        // GET: Company_Information
        public ActionResult Index()
        {
            return View(db.Company_Information.ToList());
        }

        // GET: Company_Information/Details/5

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Company_Information company_Information = db.Company_Information.Find(id);
            if (company_Information == null)
            {
                return HttpNotFound();
            }
            return View(company_Information);
        }



        // GET: Company_Information/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Company_Information/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CIK,Name,Address_1,Address_2,City___State,Phone,SIC")] Company_Information company_Information)
        {
            if (ModelState.IsValid)
            {
                db.Company_Information.Add(company_Information);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(company_Information);
        }

        // GET: Company_Information/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Company_Information company_Information = db.Company_Information.Find(id);
            if (company_Information == null)
            {
                return HttpNotFound();
            }
            return View(company_Information);
        }

        // POST: Company_Information/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CIK,Name,Address_1,Address_2,City___State,Phone,SIC")] Company_Information company_Information)
        {
            if (ModelState.IsValid)
            {
                db.Entry(company_Information).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(company_Information);
        }

        // GET: Company_Information/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Company_Information company_Information = db.Company_Information.Find(id);
            if (company_Information == null)
            {
                return HttpNotFound();
            }
            return View(company_Information);
        }

        // POST: Company_Information/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Company_Information company_Information = db.Company_Information.Find(id);
            db.Company_Information.Remove(company_Information);
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
