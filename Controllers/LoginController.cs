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
    public class LoginController : Controller
    {
        public const string SessionKeyName = "_Name";

        [HttpGet]
        public ActionResult Index()
        {
            HttpContext.Session.Remove(SessionKeyName);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Login user)
        {
   
            string userName = "sonal@gmail.com";
            string password = "Abc123@";


            VesselBlendersContext context = new VesselBlendersContext();
            using (var transaction = context.Database.BeginTransaction())
            {
                //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[User] ON");

                User userObject = context.User.Where(u=>u.Email == user.Username).FirstOrDefault();
                if(userObject != null)
                {
                    ViewBag.UserName = user.Username;
                    //if (string.IsNullOrEmpty(HttpContext.Session.GetString(SessionKeyName)))
                    {
                        HttpContext.Session.SetString(SessionKeyName, user.Username);

                    }

                    ViewBag.UserName = HttpContext.Session.GetString(SessionKeyName);
                    int val = userObject.Role.Trim().CompareTo("User");
                    if (userObject.Role.Trim().CompareTo("User") == 0)
                        return View("UserDashboard");
                        //return RedirectToAction("UserDashboard");
                    else
                        return View("CordinatorDashboard", user);
                }

                return View();
            }

            /*if (userName == user.Username && password == user.Password)
            {

                ViewBag.UserName = user.Username;
                //if (string.IsNullOrEmpty(HttpContext.Session.GetString(SessionKeyName)))
                {
                    HttpContext.Session.SetString(SessionKeyName, user.Username);

                }

                ViewBag.UserName = HttpContext.Session.GetString(SessionKeyName);

                return View("CordinatorDashboard", user);
            }
            else
            {
                ViewBag.error = "Invalid Credentials, Please try again!!";
                return View("Index");
            }*/
        }

        public ActionResult CordinatorDashboard()
        {
            ViewBag.UserName = HttpContext.Session.GetString("_Name");
            return View();
        }
        [HttpGet]
        public ActionResult Calculation()
        {
            ViewBag.UserName = HttpContext.Session.GetString("_Name");
            return View();
        }
        [HttpPost]
        public ActionResult Calculation(EmployeeIncentive data)
        {
            ViewBag.UserName = HttpContext.Session.GetString("_Name");
            double totalincentivedays = data.total_incentive_days;
            return View("GetDetails", data);
        }



        [HttpGet]
        public ActionResult GetDetails(int totalincentivedays)
        {
            ViewBag.UserName = HttpContext.Session.GetString("_Name");
            EmployeeIncentive obj = new EmployeeIncentive();
            obj.days_of_bth = 2;
            obj.flatdayrate = 100;
            obj.Transportation_allowance = 25;
            obj.incentivemultipliertill10 = 0.5;
            obj.incentivemultipliertill11to15 = 1;
            obj.incentivemultiplier16plus = 2.0;
            obj.hourincentiverate = 125;
            obj.meals_allowance = 45;
            obj.total_incentive_days = totalincentivedays;
            ViewBag.totalin = totalincentivedays;
            return View(obj);

        }
        [HttpPost]
        public ActionResult GetDetails(EmployeeIncentive data)
        {
            ViewBag.UserName = HttpContext.Session.GetString("_Name");
            double totalincentivedays = data.total_incentive_days;
            data.incentivemultipliertill10 = 2;
            data.incentivemultipliertill11to15 = 1;
            data.incentivemultiplier16plus = 2;
            data.hourincentiverate = 125;
            if (data.total_incentive_days >= 16)
            {
                data.output4 = data.incentivemultipliertill10 * 10 * data.hourincentiverate;
                data.output6 = (totalincentivedays - 15) * data.incentivemultiplier16plus * data.hourincentiverate;
                data.output5 = 5 * data.incentivemultipliertill11to15 * data.hourincentiverate;
                data.output1 = 10;
                data.output2 = 5;
                data.output3 = data.total_incentive_days - 15;
            }
            if (data.total_incentive_days >= 11 && data.total_incentive_days <= 15)
            {
                data.output4 = data.incentivemultipliertill10 * 10 * data.hourincentiverate;
                data.output5 = (data.total_incentive_days - 10) * data.incentivemultipliertill11to15 * data.hourincentiverate;
                data.output6 = 0;
                data.output1 = 10;
                data.output2 = data.total_incentive_days - 10;
                data.output3 = 0;

            }
            if (data.total_incentive_days <= 10)
            {
                data.output4 = data.incentivemultipliertill10 * 10 * data.hourincentiverate;
                data.output5 = 0;
                data.output6 = 0;
                data.output1 = data.total_incentive_days;
                data.output2 = 0;
                data.output3 = 0;
            }
                data.flatdayrate = 100;
                data.output9 = data.flatdayrate * data.days_of_bth;
                data.output10 = data.output9 + data.output4 + data.output5 + data.output6;
                data.monthlycellphonerate = 100;
                data.meals_allowance = 45;
                data.Transportation_allowance = 15;
                data.output11 = data.monthlycellphonerate + data.others + data.flatratetravel;
                data.output12 = data.meals_allowance * data.total_incentive_days;
                data.output13 = data.Transportation_allowance + data.total_incentive_days;
                data.output14 = data.output12 + data.output13;
                data.output15 = data.output14 + data.output10 + data.output11;
                return View("GetDetails", data);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}