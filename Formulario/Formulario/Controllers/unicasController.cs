using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Formulario.Data;
using Formulario.Models;

namespace Formulario.Controllers
{
    public class unicasController : Controller
    {
        private Context db = new Context();

        // GET: unicas
        public ActionResult Index()
        {
            return View(db.unicas.ToList());
        }

        // GET: unicas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            unica unica = db.unicas.Find(id);
            if (unica == null)
            {
                return HttpNotFound();
            }
            return View(unica);
        }

        // GET: unicas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: unicas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Idade,Telefone")] unica unica)
        {
            if (ModelState.IsValid)
            {
                db.unicas.Add(unica);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(unica);
        }

        // GET: unicas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            unica unica = db.unicas.Find(id);
            if (unica == null)
            {
                return HttpNotFound();
            }
            return View(unica);
        }

        // POST: unicas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Idade,Telefone")] unica unica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(unica).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(unica);
        }

        // GET: unicas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            unica unica = db.unicas.Find(id);
            if (unica == null)
            {
                return HttpNotFound();
            }
            return View(unica);
        }

        // POST: unicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            unica unica = db.unicas.Find(id);
            db.unicas.Remove(unica);
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
