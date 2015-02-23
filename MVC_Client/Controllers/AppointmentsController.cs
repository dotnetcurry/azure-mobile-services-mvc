using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Client.Controllers
{
    public class AppointmentsController : Controller
    {
        // GET: Appointments
         [Authorize]
        public ActionResult Index()
        {
            //var uSplit = User.Identity.Name.Split('@');
            ViewBag.UserName = User.Identity.Name;
            return View();
        }
    }
}