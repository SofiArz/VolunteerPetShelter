using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VolunteerPetShelter.Controllers
{
    public class HomeMenuController : Controller
    {
        // GET: HomeMenu
        public ActionResult Index()
        {     //preguntamos si está logueado 
            //(porque en el login agregamos el objeto del usuario)
           if (Session["LoggedUser"] == null)
                return RedirectToAction("Login", "User");

            ViewBag.Title = "Inicio";
            return View();
        }

        public ActionResult Volunteer()
        {
            ViewBag.Title = "Voluntarios";
            return View();
        }
        public ActionResult VolunteerForm()
        {
            ViewBag.Title = "Formulario Voluntarios";
            return View();
        }

        public ActionResult Adoption()
        {
            ViewBag.Title = "Adopta";
            return View();

        }

        public ActionResult DogAdoptionForm()
        {
            ViewBag.Title = "Adopta";
            return View();

        }


    }
}