using Exercise_MVCAndWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercise_MVCAndWebApi.Controllers
{
    public class HtmlHelperTestController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }        
    }
}