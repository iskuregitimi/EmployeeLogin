using EmployeeLogin.BLL;
using EmployeeLogin.Filters;
using EmployeeLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeLogin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }


        [MyAuthenticationFilter]
        public ActionResult Logout()
        {
            Session["Employee"] = null;
            return RedirectToAction("Index");

        }



        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            var employee = AccessBLL.LoginUser(model.UserName, model.Password);

            if (employee == null)
            {
                TempData["Hata"] = "Kullanıcı bulunamadı";
                return RedirectToAction("Index");
            }
            else
            {
                Session["Employee"] = employee;
                return RedirectToAction("Index", "Home");
            }

        }



    }
}