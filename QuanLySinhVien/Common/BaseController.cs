﻿using QuanLySinhVien.ViewModel;
using QuanLySinhVien.ViewModel.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace QuanLySinhVien.Common
{
    public class BaseController : Controller
    {
        // GET: Admin/base
        protected override void OnActionExecuting(ActionExecutingContext filerContext)
        {
            var sess = (userLoginViewModel)Session[commonConst.user_session];
            if (sess == null)
            {
                filerContext.Result = new RedirectToRouteResult
                    (new RouteValueDictionary(new { controller = "Login", action = "Index"}));
            }
            base.OnActionExecuting(filerContext);
        }
    }
}