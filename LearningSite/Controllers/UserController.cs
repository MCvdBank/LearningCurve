using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearningSite.Models;

namespace LearningSite.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            User u1 = new User(1, "MC");


            return View(u1);
        }
    }
}