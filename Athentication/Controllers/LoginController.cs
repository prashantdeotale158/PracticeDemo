using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Athentication.Models;
namespace Athentication.Controllers
{
    public class LoginController : Controller
    {
       
        public ActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(UserData userData,string ReturnUrl)
        {
            if(IsValid(userData))
            {
                FormsAuthentication.SetAuthCookie(userData.Userid, false);
                return Redirect(ReturnUrl);
            }
            else
            {
            
            return View(userData);
            }
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return Redirect("/Home/Index");
        }

        private bool IsValid(UserData userData)
        {
            return (userData.Userid == "ppp" && userData.Password == "123");
        }
    }
}