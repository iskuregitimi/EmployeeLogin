using EmployeeLogin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeLogin.Models
{
    public class CustomerModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public Address Adres { get; set; }
        public Phone Telefon { get; set; }
        public Email Mail { get; set; }
    }
}