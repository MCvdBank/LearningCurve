using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearningCurve.Models;

namespace LearningCurve.Controllers
{
    public class PolymerController : Controller
    {
        // GET: Polymer
        public ActionResult Index()
        {
            Person ins = new Person { ID = 1, Name = "RM"};
            return View(ins);
        }
    }
}