using EmployeeLogin.BLL;
using EmployeeLogin.DAL;
using EmployeeLogin.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeLogin.Controllers
{
    public class OrderController : Controller
    {

        [MyAuthenticationFilter]
        // GET: Order
        public ActionResult Index()
        {
            var employee = Session["Employee"] as Employee;

            ViewBag.OnaylaVisibilityText = "hidden";
            ViewBag.ReddetVisibilityText = "hidden";
            ViewBag.KargolaVisibilityText = "hidden";

            if (AccessBLL.UserHasRole(employee.Email, "Admin"))
            {
                ViewBag.OnaylaVisibilityText = "visible";
                ViewBag.ReddetVisibilityText = "visible";
                ViewBag.KargolaVisibilityText = "visible";
            }

            return View();
        }

        public ActionResult Approve()
        {
            if (Session["Employee"] == null)
            {
                return RedirectToAction("Hata", "Home");
            }

            var employee = Session["Employee"] as Employee;

            if (!AccessBLL.UserHasRole(employee.Email, "Admin"))
            {
                return RedirectToAction("Hata", "Home");
            }

            //Onaylama işlemini yap

            return RedirectToAction("Index");
        }



    }
}