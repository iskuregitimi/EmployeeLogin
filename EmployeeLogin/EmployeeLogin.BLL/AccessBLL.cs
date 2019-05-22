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
        static CRMModel context = new CRMModel();
        public static Employee LoginUser(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new MissingFieldException("kullanıcı adı yada şifreyi boş gönderemezsiniz");
            }
            var employee = context.Employees.Where(e => e.Username == username && e.Password == password).FirstOrDefault();
            return employee;
        }

        public static List<Roller> GetUserRoles(string userName)
        {

            var result = from e in context.Employees
                         join er in context.RolEmployees on e.EmployeeId equals er.EmployeeId
                         join r in context.Rollers on er.RoleId equals r.RoleId
                         where e.Username == userName
                         select r;

            return result.ToList();
        }

        public static bool UserHasRole(string username, string roleName)
        {
            var result = (from e in context.Employees
                          join er in context.RolEmployees on e.EmployeeId equals er.EmployeeId
                          join r in context.Rollers on er.RoleId equals r.RoleId
                          where e.Username == username && r.RoleName == roleName
                          select r).Any();

            return result;
        }
    }
}
