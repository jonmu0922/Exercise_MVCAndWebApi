using Exercise_MVCAndWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercise_MVCAndWebApi.Controllers
{
    public class AjaxHelperTestController : Controller
    {
        // GET: AjaxHelperTest
        public ActionResult Index()
        {
            // https://jeffprogrammer.wordpress.com/2015/10/30/asp-net-mvc-ajaxhelper/
            //要安裝 Microsoft.jQuery.Unobtrusive.Ajax

            return View();
        }

        public ActionResult Hello(string name)
        {
            return Content("Hello " + name);
        }

        public PartialViewResult HelloPartialView(string name)
        {
            return PartialView("_Hello", new UserModel() { Name = name});
        }
    }
}