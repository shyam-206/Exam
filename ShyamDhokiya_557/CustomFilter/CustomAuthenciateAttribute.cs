﻿using ShyamDhokiya_557.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ShyamDhokiya_557.CustomFilter
{
    public class CustomAuthenciateAttribute : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if ((SessionHelper.UserId != 0) && SessionHelper.Useremail  != "" && SessionHelper.Username != "")
            {
                return true;
            }
            return false;
        }


        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary{
                {"controller", "Login"},
                {"action","Login"},
            });
        }
    }
}