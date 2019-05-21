using EmployeeLogin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLogin.BLL
{
    public class CustomerBLL
    {
        static EmployeeLoginDataContext dataContext = new EmployeeLoginDataContext();

        public static List<Customer> GetCustomers()
        {
            var customer = dataContext.Customer.ToList();

            return customer;
        }

        public static void AddCustomer(Customer customer)
        {
            dataContext.Customer.Add(customer);
            dataContext.SaveChanges();
        }
    }
}
