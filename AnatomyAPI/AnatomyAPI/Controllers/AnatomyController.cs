using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnatomyAPI.Controllers
{
    public class AnatomyController : Controller
    {
        public ActionResult Detail()
        {
            ViewBag.bodySection = "heart";
            ViewBag.description = "<p>Keeps the blood flowing and the body moving</p>";
            ViewBag.mainSections = new string[]
            {
                "left ventricle",
                "right ventricle",
                "left atrium",
                "right atrium"
            };
            
            return View();
        }
    }
} 
