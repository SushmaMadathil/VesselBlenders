using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VesselBlenders.Models
{
    public class Login
    {
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Username { get; set; }

        //[StringLength(12, MinimumLength = 6)]
        //[RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$[0-9]" , ErrorMessage = "Password must be 6 character")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public Login()
        {

        }
        //public Login(string username, string password)
        //{
        //    Username = username;
        //}

        //public static List<Login> GetSampleData()
        //{
        //    // ID #3 IS INTENTIONALLY A DUPLICATE
        //    List<Login> login = new List<Login>();
        //    login.Add(new Login("Sonal", "Abc123"));
        //    login.Add(new Login("Garima", "Abc123"));
        //    login.Add(new Login("Himali", "Abc123"));

        //    return login;

        //}
    }
}

