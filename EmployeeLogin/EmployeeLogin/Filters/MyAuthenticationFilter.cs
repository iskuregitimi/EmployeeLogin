using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeLogin.Filters
{
    public class MyAuthenticationFilter : ActionFilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Session["Employee"]==null)
            {
                filterContext.Result = new RedirectResult("~/Hata/Hata");
            }
        }

       public void OnAuthorizationChallenge(AuthorizationContext filterContext)
        {
            
        }
    }
}