﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace EmployeeLogin.Filters
{
    public class MyAuthenticationFilter : ActionFilterAttribute, IActionFilter
    {

        public void OnAuthentication(AuthenticationContext filterContext)
        {
            if (filterContext.HttpContext.Session["Employee"]==null)
            {
                filterContext.Result = new RedirectResult("~/Home/Hata");
            }

        }
        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {

        }

    }



}