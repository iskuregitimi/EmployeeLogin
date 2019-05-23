using EmployeeLogin.BLL;
using EmployeeLogin.DAL;
using EmployeeLogin.UI.Web.Filters;
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

        [MyAuthenticationFilter]
        public ActionResult AddCustomer()
        {
            return View();
        }

        [MyAuthenticationFilter]
        public ActionResult SaveCustomer(Customer model)
        {
            CustomerBLL.SaveCustomer(model);
            return RedirectToAction("Homepage", "Home");
        }

        [MyAuthenticationFilter]
        public ActionResult getAllCustomers()
        {
            return View();
        }
    }
}