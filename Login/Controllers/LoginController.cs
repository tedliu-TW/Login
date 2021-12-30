using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Login.Models;
using Login.Models.DomainModels;
using Login.Models.Repositories;
using Login.Models.Services;

namespace Login.Controllers
{
    public class LoginController : Controller
    {
        public readonly AccountService service;
        private readonly AccountRepository db;


        Account account = new Account();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Account model)
        {
            if (ModelState.IsValid)
            {
                var data =  service.Login()
            }
            return View();
        }


        public ActionResult UserDashBoard()
        {
            if (Session["UserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

    }
}