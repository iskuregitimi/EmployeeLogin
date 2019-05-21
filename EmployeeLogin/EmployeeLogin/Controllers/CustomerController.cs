using EmployeeLogin.BLL;
using EmployeeLogin.Entity;
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
            List<Customer> customerList = CustomerBLL.GetCustomers();
            return View(customerList);
        }
        [HttpGet]
        public ActionResult  AddCustomer()
        {
            Customer model = new Customer();
            return View(model);
        }

        [HttpPost]
        public ActionResult InsertCustomer(Customer model)
        {
            CustomerBLL.InsertCustomer(model);
            return RedirectToAction("Index");

        }

    }
}