using EmployeeLogin.BLL;
using EmployeeLogin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeLogin.UI.Web.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddCustomer()
        {
            return View();
        }

        public ActionResult SaveCustomer(Customer model)
        {
            CustomerBLL.SaveCustomer(model);
            return RedirectToAction("Homepage", "Home");
        }
    }
}