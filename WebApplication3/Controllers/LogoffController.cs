﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class LogoffController : Controller
    {
        // GET: Logoff
        public ActionResult Logoff()
        {
            Session["User"] = null;
            return RedirectToAction("Index","Access");
        }
    }
}