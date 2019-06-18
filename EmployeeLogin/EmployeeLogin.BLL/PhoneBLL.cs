using EmployeeLogin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLogin.BLL
{
    public static class PhoneBLL
    {
        static EmployeeLoginDataContext db = new EmployeeLoginDataContext();

        public static void AddPhone(Phone phone)
        {
            db.Phone.Add(phone);
            db.SaveChanges();
        }

        public static List<Phone> GetPhones(int id)
        {
            return db.Phone.Where(x => x.CustomerID == id).ToList();
        }
    }
}
