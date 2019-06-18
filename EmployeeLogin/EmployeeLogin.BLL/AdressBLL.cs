
using EmployeeLogin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLogin.BLL
{
    public static class AdressBLL
    {
        static EmployeeLoginDataContext db = new EmployeeLoginDataContext();
        public static void AddAddress(Address adres)
        {
            db.Address.Add(adres);
            db.SaveChanges();
        }

        public static List<Address> GetAddresses(int id)
        {
            return db.Address.Where(x=>x.CustomerID == id).ToList();
        }
    }
}
