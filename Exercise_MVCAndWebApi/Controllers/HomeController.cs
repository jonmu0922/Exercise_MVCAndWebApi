using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;

namespace Exercise_MVCAndWebApi.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            // 實體檔案路徑
            ViewBag.FilePath = HostingEnvironment.MapPath("~/app_data/test.txt");


            return View();
        }
    }
}