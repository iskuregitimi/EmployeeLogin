using EmployeeLogin.UI.Web.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeLogin.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [MyAuthenticationFilter]
        public ActionResult Homepage()
        {
            return View();
        }

        public ActionResult LoginError()
        {
            return View();
        }
    }
}