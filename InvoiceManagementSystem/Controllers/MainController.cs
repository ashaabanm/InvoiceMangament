﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Collcection.DAL;
using Collection.DSL;
namespace InvoiceManagementSystem.Controllers
{
    public class MainController : Controller
    {
        UserDSL u_dsl = new UserDSL();
        // GET: Main
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User u)
        {
            Session["UserInfo"] = u_dsl.Login(u) as User;
            var temp = Session["UserInfo"] as User;
            if (temp != null)
            {
                return RedirectToAction("Index", "Invoice");
            }
            return View();
        }
        public ActionResult profile()
        {
            return View();
        }
    }
}