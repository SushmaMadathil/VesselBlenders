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
    public class RegisterUserController : Controller
    {

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.UserName = HttpContext.Session.GetString("_Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Registration user)
        {
            ViewBag.UserName = HttpContext.Session.GetString("_Name");
            return View();
        }
  
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}