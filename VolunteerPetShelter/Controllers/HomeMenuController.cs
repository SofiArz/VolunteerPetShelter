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
        {
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


    }
}