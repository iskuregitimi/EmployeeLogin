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
            var customers = dataContext.Customer.ToList();            
            return customers;
        }

        public static Customer GetCustomer(int id)
        {
            var customer = dataContext.Customer.FirstOrDefault(x => x.CustomerID == id);
            return customer;
        }

        public static int AddCustomer(Customer customer)
        {
            dataContext.Customer.Add(customer);
            dataContext.SaveChanges();
            return customer.CustomerID;
        }
        public static void Edit(Customer customer)
        {
            dataContext.SaveChanges();
        }
    }
}
