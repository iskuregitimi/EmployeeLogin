using EmployeeLogin.BLL;
using EmployeeLogin.DAL;
using EmployeeLogin.Filters;
using EmployeeLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeLogin.Controllers
{
    public class CustomerController : Controller
    {
        [MyAuthenticationFilter]
        public ActionResult AllCustomer()
        {
            var model = CustomerBLL.GetCustomers();

            return View(model);
        }


        [MyAuthenticationFilter]
        public ActionResult AddCustomer()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AddCustomer(CustomerModel customer)
        {
            Customer cust = new Customer
            {
                Surname=customer.Surname,
                Name=customer.Name,
                BirthDate=customer.BirthDate
            };
            int customerID = CustomerBLL.AddCustomer(cust);
            customer.Adres.CustomerID = customerID;
            AdressBLL.AddAddress(customer.Adres);
            customer.Mail.CustomerID = customerID;
            MailBLL.AddMail(customer.Mail);
            customer.Telefon.CustomerID = customerID;
            PhoneBLL.AddPhone(customer.Telefon);

            return RedirectToAction("AllCustomer");
        }
        [MyAuthenticationFilter]
        public ActionResult Edit(int id)
        {
            Customer customer = CustomerBLL.GetCustomer(id);

            return View(customer);
        }

        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            Customer cust = CustomerBLL.GetCustomer(customer.CustomerID);
            cust.CustomerID = customer.CustomerID;
            cust.BirthDate = customer.BirthDate;
            cust.Surname = customer.Surname;
            cust.Name = customer.Name;

            CustomerBLL.Edit(cust);

            return View();
        }

        public ActionResult Mail(int id)
        {
            List<Email> mail = MailBLL.GetMails(id);

            return View(mail);
        }
    }
}