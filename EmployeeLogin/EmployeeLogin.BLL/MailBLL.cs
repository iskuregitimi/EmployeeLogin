using EmployeeLogin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLogin.BLL
{
    public static class MailBLL
    {
        static EmployeeLoginDataContext db = new EmployeeLoginDataContext();
        public static void AddMail(Email email)
        {
            db.Email.Add(email);
            db.SaveChanges();
        }

        public static List<Email> GetMails(int id)
        {
            return db.Email.Where(x => x.CustomerID == id).ToList();
        }
    }
}
