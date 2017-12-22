using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VolunteerPetShelter.Models;

namespace VolunteerPetShelter.Controllers
{
    public class CRUDVolunteerFormsController : Controller
    {
        private VolunteerPetShelterContext db = new VolunteerPetShelterContext();

        // GET: CRUDVolunteerForms
        public ActionResult Index()
        {
          
            return View(db.VolunteerForms.ToList());
        }

        // GET: CRUDVolunteerForms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VolunteerForm volunteerForm = db.VolunteerForms.Find(id);
            if (volunteerForm == null)
            {
                return HttpNotFound();
            }
            return View(volunteerForm);
        }

        // GET: CRUDVolunteerForms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CRUDVolunteerForms/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,LastName,Birthdate,Location,Address,Email,Telephone,VolunteerFormID,Question1,Question2")] VolunteerForm volunteerForm)
        {
            
            if (ModelState.IsValid)
            {   
                db.Persons.Add(volunteerForm);             
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(volunteerForm);
        }

        // GET: CRUDVolunteerForms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VolunteerForm volunteerForm = db.VolunteerForms.Find(id);
            if (volunteerForm == null)
            {
                return HttpNotFound();
            }
            return View(volunteerForm);
        }

        // POST: CRUDVolunteerForms/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,LastName,Birthdate,Location,Address,Email,Telephone,VolunteerFormID,Question1,Question2")] VolunteerForm volunteerForm)
        {
            if (ModelState.IsValid)
            {
                db.Entry(volunteerForm).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(volunteerForm);
        }

        // GET: CRUDVolunteerForms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VolunteerForm volunteerForm = db.VolunteerForms.Find(id);
            if (volunteerForm == null)
            {
                return HttpNotFound();
            }
            return View(volunteerForm);
        }

        // POST: CRUDVolunteerForms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VolunteerForm volunteerForm = db.VolunteerForms.Find(id);
            db.Persons.Remove(volunteerForm);
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
