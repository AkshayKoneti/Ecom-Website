using CommonLayer.Models;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoWeb.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult RegisterUser() {
            return View();
        }

        [HttpGet]
        public ActionResult Login() {

            return View();
        }

        [HttpPost]
        public ActionResult Login(Register re)
        {
            Register DB = new Register();
            DB.Username = re.Username;
            DB.Password = re.Password;
            Repository repo = new Repository();
            repo.VerifyLogin(DB);
            return View("RegisterUser");
        }


        [HttpPost]
        public ActionResult RegisterUser(Register RegisteredUserDeatils)
        {
            Register userDetails = new Register();
            userDetails.CustId = RegisteredUserDeatils.CustId;
            userDetails.FirstName = RegisteredUserDeatils.FirstName;
            userDetails.LastName = RegisteredUserDeatils.LastName;
            userDetails.Username = RegisteredUserDeatils.Username;
            userDetails.Password = RegisteredUserDeatils.Password;
            userDetails.EMail = RegisteredUserDeatils.EMail;
            userDetails.PrimaryAddress1 = RegisteredUserDeatils.PrimaryAddress1;
            userDetails.PrimaryAddress2 = RegisteredUserDeatils.PrimaryAddress2;
            userDetails.City = RegisteredUserDeatils.City;
            userDetails.State = RegisteredUserDeatils.State;
            userDetails.Country = RegisteredUserDeatils.Country;
            userDetails.PostalCode = RegisteredUserDeatils.PostalCode;

            Repository repo = new Repository();
            repo.SaveRegisteredUsers(userDetails);

            return View();
            
        }
    }
}