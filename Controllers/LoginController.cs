﻿using Microsoft.AspNetCore.Mvc;
using KhumaloCraftEmporium.Models;

namespace KhumaloCraftEmporium.Controllers
{
    public class LoginController : Controller
    {

        private readonly LoginModel login;

        public LoginController()
        {
            login = new LoginModel();
        }

        [HttpPost]
        public ActionResult Privacy(string email, string name)
        {
            var loginModel = new LoginModel();
            int userID = loginModel.SelectUser(email, name);
            if (userID != -1)
            {
                HttpContext.Session.SetInt32("UserID", userID);
                return RedirectToAction("Index", "Home", new { userID = userID });
            }
            else
            {
                
                return View("LoginFailed");
            }
        }
    }
}
