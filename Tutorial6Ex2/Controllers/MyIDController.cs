using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tutorial6Ex2.Controllers
{
    public class MyIDController : Controller
    {
        // GET: MyID
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DescribeMyself()
        {
            ViewData["Name"] = "Aven Matthew Majellano";
            ViewData["StudentID"] = "20032744";
            return View();

        }
    }
}