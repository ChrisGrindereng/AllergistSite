﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AllergistSite.Controllers
{
    public class AppointmentController : Controller
    {
        // GET: Appointment
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TexasMedicalCenter()
        {
            return View();
        }

        public ActionResult theGalleria()
        {
            return View();
        }

        public ActionResult theWoodlands()
        {
            return View();
        }
    }
}