using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearnMVC.Filters;
using LearnMVC.ViewModels;

namespace LearnMVC.Controllers
{
    [AllowAnonymous]
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index()
        {
            Exception e = new Exception("Invalid Controller or/and Action Name");
            HandleErrorInfo eInfo = new HandleErrorInfo(e, "Unknown", "Unknown");
            return View("Error", eInfo);
        }

        [HandleError(View="NotFoundError")]
        [HeaderFooterFilter]
        public ActionResult NotFound()
        {
            ErrorViewModel evm = new ErrorViewModel();;
            return View("NotFoundError", evm);
        }
    }
}