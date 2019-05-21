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
        public ActionResult  AddCustomer()
        {
            Customer model = new Customer();
            return View(model);
        }
        public ActionResult InsertCustomer(Customer model)
        {
            CustomerBLL.InsertCustomer(model);
            return RedirectToAction("Index");

        }

    }
}