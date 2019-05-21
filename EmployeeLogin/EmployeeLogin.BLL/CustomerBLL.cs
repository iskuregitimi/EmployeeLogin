using EmployeeLogin.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLogin.BLL
{
   public static class CustomerBLL
    {
        public static List<Customer> GetCustomers()
        {
            EmployeeLoginDataContext dbContext = new EmployeeLoginDataContext();

            return dbContext.Customer.ToList();
        }
        public static void InsertCustomer(Customer entity)
        {
            EmployeeLoginDataContext dbContext = new EmployeeLoginDataContext();
            dbContext.Customer.Add(entity);
            dbContext.SaveChanges();

        }
    }
}
