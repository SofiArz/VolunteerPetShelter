using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VolunteerPetShelter.Controllers
{
    public class MenuAdminController : Controller
    {
        // GET: MenuAdmin
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult AwaitingRequests()
        {
            return View();
        }

        public ActionResult RejectedRequests()
        {
            return View();
        }

        public ActionResult AcceptedRequests()
        {
            return View();
        }

        public ActionResult Contacted()
        {
            return View();
        }
    }
}