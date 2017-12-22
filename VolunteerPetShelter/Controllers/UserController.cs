using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VolunteerPetShelter.Models;

namespace VolunteerPetShelter.Controllers
{
    public class UserController : Controller
    {
        private VolunteerPetShelterContext db = new VolunteerPetShelterContext();

        // GET: User
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult LogOut()
        {
            Session["LoggedUser"] = null;
            return RedirectToAction("Index","HomeMenu");
        }

        [HttpPost]
        public ActionResult DoLogin(string email, string password)
        {
            //buscamos al usuario 
           
            User user = db.Users.FirstOrDefault(u => u.MailAsId.Equals(email));
            if (user != null
                && user.Password.Equals(password)) //si existe (no queda null) y la contraseña coincide
            {
                Session["LoggedUser"] = user; //agregamos el objeto usuario a la sesión, para después tener control sobre él
                Session["username"] = user.Name;
                return RedirectToAction("Home", "MenuAdmin");
            }
            //si no existe el usuario o lo contraseña no coincide
            return RedirectToAction("Login", "User");
        }


     

        // GET: User/Edit/5
        public ActionResult Edit(string id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            User user = db.Users.Find(id);

            if (user == null)
            {
                return HttpNotFound();
            }
            return View();
            
        }

     

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
