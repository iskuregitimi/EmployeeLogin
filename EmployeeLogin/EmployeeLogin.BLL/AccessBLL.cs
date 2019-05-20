using EmployeeLogin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLogin.BLL
{
    public static class AccessBLL
    {
        public static Employee LoginUser(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new MissingFieldException("kullanıcı adı yada şifreyi boş gönderemezsiniz");
            }

            EmployeeLoginDataContext dataContext = new EmployeeLoginDataContext();
            var employee = dataContext.Employee.Where(e => e.Email == username && e.Password == password).FirstOrDefault();
            return employee;
        }

        public static List<Role> GetUserRoles(string userName)
        {
            EmployeeLoginDataContext dataContext = new EmployeeLoginDataContext();

            var result = from e in dataContext.Employee
                         join er in dataContext.EmployeeRole on e.EmployeeID equals er.EmployeeID
                         join r in dataContext.Role on er.RoleID equals r.RoleID
                         where e.Email == userName
                         select r;

            return result.ToList();
        }

        public static bool UserHasRole(string username, string roleName)
        {
            EmployeeLoginDataContext dataContext = new EmployeeLoginDataContext();

            var result = (from e in dataContext.Employee
                          join er in dataContext.EmployeeRole on e.EmployeeID equals er.EmployeeID
                          join r in dataContext.Role on er.RoleID equals r.RoleID
                          where e.Email == username && r.Name == roleName
                          select r).Any();

            return result;
        }
    }
}
