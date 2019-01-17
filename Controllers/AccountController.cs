using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Group3.Models;
using Microsoft.AspNetCore.Http;
using VesselBlenders.Models;
using Microsoft.EntityFrameworkCore;

namespace Group3.Controllers
{
    public class AccountController : Controller
    {
        //public IActionResult Index()
        //{
        //    using (OurDbContext Db = new OurDbContext())
        //    {               
        //        return View(Db.Registration.ToList());
        //    }
              
        //}
        public IActionResult register()
        {
            ViewBag.UserName = HttpContext.Session.GetString("_Name");
            return View();
        }

        [HttpPost]
        public IActionResult register(User account)
        {
            ViewBag.UserName = HttpContext.Session.GetString("_Name");
            if (ModelState.IsValid)
            {
                /*using (OurDbContext Db = new OurDbContext())
                {
                    //check if username is exists
                    var result = from u in Db.UserAccount
                                  where u.UserName.ToUpper() == account.UserName.ToUpper()
                                  select new { u.UserName };
                    string output = "";
                    foreach (var r in result)
                    {
                        output += r.UserName;
                    }

                    if (output.Length==0)
                    {
                        UserAccount registration = new UserAccount();

                        registration.Role = account.Role;
                        registration.FirstName = account.FirstName;
                        registration.LastName = account.LastName;
                        registration.Email = account.Email;
                        registration.UserName = account.UserName;
                        registration.Password = account.Password;
                        registration.ConfirmPassword = account.ConfirmPassword;

                        Db.UserAccount.Add(registration);
                        Db.SaveChanges();
                        ViewBag.Message = account.UserName+ " successfully registered. ";
                    }
                    else
                    {
                        
                        ViewBag.Message = "UserName:" + account.UserName + " is already exists. ";
                    }
                    
                    //return View("Confirmation", account);
                }*/
                VesselBlendersContext context = new VesselBlendersContext();
                using (var transaction = context.Database.BeginTransaction())
                {
                    //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[User] ON");

                    context.User.Add(account);
                    context.SaveChanges();

                    //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[User] OFF");

                    transaction.Commit();
                    ViewBag.result = "User Created!";
                }

                ModelState.Clear();
                
            }
            
            return View();
        }
    }


    /*
     * 
     * Tools –> NuGet Package Manager –> Package Manager Console
     * Install-Package Microsoft.EntityFrameworkCore.Tools –Pre
     * Install-Package Microsoft.EntityFrameworkCore.SqlServer.Design
     * Scaffold-DbContext "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VesselBlenders;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
     * 
     * 
     * 
     * 
     * CREATE TABLE [dbo].[User]
        (
	    [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
        [UserName] NVARCHAR(50) NOT NULL UNIQUE, 
        [FirstName] NVARCHAR(50) NULL, 
        [LastName] NVARCHAR(50) NULL, 
        [Email] NVARCHAR(50) NULL, 
        [Password] NVARCHAR(50) NULL, 
        [Role] NCHAR(10) NULL
        )
     */
}


