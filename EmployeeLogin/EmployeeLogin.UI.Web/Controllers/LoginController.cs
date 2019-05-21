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
            //var employee = AccessBLL.LoginUser(model.UserName, model.Password);

            //if (employee == null)
            //{
            //    TempData["Hata"] = "Kullanıcı bulunamadı";
            //    return RedirectToAction("Index");
            //}
            //else
            //{
            //    Session["Employee"] = employee;
            //    return RedirectToAction("Index", "Home");
            //}
            return RedirectToAction("Homepage","Home");

        }
    }
}