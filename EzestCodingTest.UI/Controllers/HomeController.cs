﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EzestCodingTest.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateUser()
        {
            ViewBag.Message = "Create new user";

            return View();
        }

        public ActionResult UserList()
        {
            ViewBag.Message = "List ofall users";

            return View();
        }
    }
}