using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VesselBlenders.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace VesselBlenders.Controllers
{
    public class UserController : Controller
    {
        public const string SessionKeyName = "_Name";


        public ActionResult Index()
        {
            HttpContext.Session.Remove(SessionKeyName);
            return View("UserDashboard");
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}