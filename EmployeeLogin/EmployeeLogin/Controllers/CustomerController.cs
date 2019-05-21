using EmployeeLogin.BLL;
using EmployeeLogin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeLogin.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AllCustomer()
        {
            if (Session["Employee"] == null)
            {
                return RedirectToAction("Hata", "Home");
            }

            
            var model = CustomerBLL.GetCustomers();

            return View(model);
        }


        
        public ActionResult AddCustomer()
        {            
            return View();
        }

        [HttpPost]
        public ActionResult AddCustomer(Customer customer)
        {
            if (Session["Employee"] == null)
            {
                return RedirectToAction("Hata", "Home");
            }
            CustomerBLL.AddCustomer(customer);

            return View();
        }
    }
}