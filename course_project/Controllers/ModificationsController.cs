using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using course_project.Models;

namespace course_project.Controllers
{
    public class ModificationsController : Controller
    {
        private GuildsEntities db = new GuildsEntities();

        // GET: Modifications
        public ActionResult Index()
        {
            return View(db.Modification.ToList());
        }

        // GET: Modifications/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Modification modification = db.Modification.Find(id);
            if (modification == null)
            {
                return HttpNotFound();
            }
            return View(modification);
        }

        // GET: Modifications/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Modifications/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_mod,nameMod,LabourInput")] Modification modification)
        {
            if (ModelState.IsValid)
            {
                db.Modification.Add(modification);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(modification);
        }

        // GET: Modifications/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Modification modification = db.Modification.Find(id);
            if (modification == null)
            {
                return HttpNotFound();
            }
            return View(modification);
        }

        // POST: Modifications/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_mod,nameMod,LabourInput")] Modification modification)
        {
            if (ModelState.IsValid)
            {
                db.Entry(modification).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(modification);
        }

        // GET: Modifications/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Modification modification = db.Modification.Find(id);
            if (modification == null)
            {
                return HttpNotFound();
            }
            return View(modification);
        }

        // POST: Modifications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Modification modification = db.Modification.Find(id);
            db.Modification.Remove(modification);
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
