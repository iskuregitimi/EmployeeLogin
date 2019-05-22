using EmployeeLogin.BLL;
using EmployeeLogin.DAL;
using EmployeeLogin.UI.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeLogin.UI.Web.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult LoginCRM(LoginModel model)
        {
            Employee employee = AccessBLL.LoginUser(model.UserName, model.Password);

            if (employee == null)
            {
                TempData["Hata"] = "Kullanıcı bulunamadı";
                return RedirectToAction("Login");
            }
            else
            {
                Session["Employee"] = employee;
                return RedirectToAction("Homepage", "Home");
            }

        }
    }
}