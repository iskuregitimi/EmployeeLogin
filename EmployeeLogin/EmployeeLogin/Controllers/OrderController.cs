﻿using EmployeeLogin.BLL;
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
        [MyAuthenticationFilter]
        public ActionResult Approve()
        {
           
            var employee = Session["Employee"] as Employee;

            if (!AccessBLL.UserHasRole(employee.Email, "Admin"))
            {
                return RedirectToAction("Hata", "Hata");
            }

            //Onaylama işlemini yap

            return RedirectToAction("Index");
        }



    }
}