using EmployeeLogin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeLogin.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult UserDetails()
        {
            if (Session["Employee"] == null)
            {
                return RedirectToAction("Hata", "Home");
            }

            var employee = Session["Employee"] as Employee;
            return View(employee);
        }
    }
}