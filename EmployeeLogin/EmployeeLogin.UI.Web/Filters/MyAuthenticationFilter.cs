using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace EmployeeLogin.UI.Web.Filters
{
    public class MyAuthenticationFilter : ActionFilterAttribute, IAuthenticationFilter
    {
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            if (filterContext.HttpContext.Session["Employee"] == null)
            {
                filterContext.Result = new RedirectResult("~/Home/LoginError");
            }
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {

        }
    }
}