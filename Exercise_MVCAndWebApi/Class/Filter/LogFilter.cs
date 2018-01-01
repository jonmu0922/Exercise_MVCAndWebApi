using Exercise_MVCAndWebApi.Class.Helper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace Exercise_MVCAndWebApi.Class.Filter
{
    public class LogFilter : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)       
        {
            LogHelper.AddLog(DateTime.Now.ToString());

            // ip
            LogHelper.AddLog(filterContext.HttpContext.Request.UserHostAddress);

            // 讀取QueryString
            foreach (var q in filterContext.HttpContext.Request.QueryString)
                LogHelper.AddLog(string.Format("{0}:{1}", q.ToString(), filterContext.HttpContext.Request.QueryString[q.ToString()]));

            // 讀取Header
            foreach (var h in filterContext.HttpContext.Request.Headers)
                LogHelper.AddLog(string.Format("{0}:{1}", h.ToString(), filterContext.HttpContext.Request.Headers[h.ToString()]));

            // Set ViewBag
            // 可以驗證使用者身分後，把資料傳回 Action
            filterContext.Controller.ViewBag.Confirm = true;
        }
    }
}