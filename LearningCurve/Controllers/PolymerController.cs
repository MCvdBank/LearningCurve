using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearningCurve.Models;
using LearningCurve.Data;

namespace LearningCurve.Controllers
{
    public class PolymerController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}