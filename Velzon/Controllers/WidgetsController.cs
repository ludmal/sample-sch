﻿using System.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Velzon.Controllers
{
    public class WidgetsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
