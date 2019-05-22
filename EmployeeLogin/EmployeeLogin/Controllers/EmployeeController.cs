using EmployeeLogin.DAL;
using EmployeeLogin.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeLogin.Controllers
{
    public class EmployeeController : Controller
    {

        [MyAuthenticationFilter]
        // GET: Employee
        public ActionResult UserDetails()
        {
            var employee = Session["Employee"] as Employee;
            return View(employee);
        }
    }
}