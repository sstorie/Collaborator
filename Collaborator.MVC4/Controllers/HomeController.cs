﻿using System.Web.Mvc;

namespace Collaborator.MVC4.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Examples()
        {
            return View();
        }
    }
}
