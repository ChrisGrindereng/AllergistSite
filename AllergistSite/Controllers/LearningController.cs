using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AllergistSite.Controllers
{
    public class LearningController : Controller
    {
        // GET: Learning
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult EpiPen()
        {
            return View();
        }
        
        public ActionResult AVQ()
        {
            return View();
        }

        public ActionResult Inhaler()
        {
            return View();
        }

        public ActionResult Spacer()
        {
            return View();
        }
    }
}