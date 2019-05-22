using EmployeeLogin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLogin.BLL
{
   
    public static class CustomerBLL
    {
        static CRMModel context = new CRMModel();

        public static void SaveCustomer(Customer cust)
        {
            Customer customer = new Customer();
            customer.Adı = cust.Adı;
            customer.Soyadı = cust.Soyadı;
            customer.Doğumtarihi = cust.Doğumtarihi;
            customer.Email = cust.Email;
            customer.Email2 = cust.Email2;
            customer.Telno = cust.Telno;
            customer.Telno2 = cust.Telno2;
            customer.Adress = cust.Adress;
            customer.Adress2 = cust.Adress2;

            context.Customers.Add(customer);
            context.SaveChanges();
        }
    }
}
