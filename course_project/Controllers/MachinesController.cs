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
    public class MachinesController : Controller
    {
        private GuildsEntities db = new GuildsEntities();

        // GET: Machines
        public ActionResult Index()
        {
            var machine = db.Machine.Include(m => m.Guild);
            return View(machine.ToList());
        }

        // GET: Machines/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Machine machine = db.Machine.Find(id);
            if (machine == null)
            {
                return HttpNotFound();
            }
            return View(machine);
        }

        // GET: Machines/Create
        public ActionResult Create()
        {
            ViewBag.fk_id_guild = new SelectList(db.Guild, "id_guild", "nameGuild");
            return View();
        }

        // POST: Machines/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_mach,fk_id_guild,firmMach,timeProcessing")] Machine machine)
        {
            if (ModelState.IsValid)
            {
                db.Machine.Add(machine);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.fk_id_guild = new SelectList(db.Guild, "id_guild", "nameGuild", machine.fk_id_guild);
            return View(machine);
        }

        // GET: Machines/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Machine machine = db.Machine.Find(id);
            if (machine == null)
            {
                return HttpNotFound();
            }
            ViewBag.fk_id_guild = new SelectList(db.Guild, "id_guild", "nameGuild", machine.fk_id_guild);
            return View(machine);
        }

        // POST: Machines/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_mach,fk_id_guild,firmMach,timeProcessing")] Machine machine)
        {
            if (ModelState.IsValid)
            {
                db.Entry(machine).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.fk_id_guild = new SelectList(db.Guild, "id_guild", "nameGuild", machine.fk_id_guild);
            return View(machine);
        }

        // GET: Machines/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Machine machine = db.Machine.Find(id);
            if (machine == null)
            {
                return HttpNotFound();
            }
            return View(machine);
        }

        // POST: Machines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Machine machine = db.Machine.Find(id);
            db.Machine.Remove(machine);
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
