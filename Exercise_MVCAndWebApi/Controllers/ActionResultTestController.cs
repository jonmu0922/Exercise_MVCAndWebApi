using Exercise_MVCAndWebApi.Class.Filter;
using Exercise_MVCAndWebApi.Class.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;

namespace Exercise_MVCAndWebApi.Controllers
{
    public class ActionResultTestController : Controller
    {
        /*
        https://msdn.microsoft.com/zh-tw/library/system.web.mvc.actionresult(v=vs.118).aspx
        
        ContentResult
        EmptyResult
        FileResult
        HttpUnauthorizedResult
        JavaScriptResult
        JsonResult
        RedirectResult
        RedirectToRouteResult
        ViewResultBase        
        */

        public ActionResult Index()
        {
            return View();
        }

        [LogFilter]
        public ActionResult TxtContent(string Name)
        {
            if(ViewBag.Confirm != null)
                return Content(Name + " " + ViewBag.Confirm);

            return Content(Name);
        }

        public ActionResult Empty()
        {
            return new EmptyResult();
        }

        public ActionResult File()
        {
            byte[] bytes = System.IO.File.ReadAllBytes(HostingEnvironment.MapPath("~/app_data/test.txt"));
            string name = "test.txt";

            //content-type 是 octet-stream 表明他就是一个字节流，浏览器默认处理字节流的方式就是下载
            return File(bytes, System.Net.Mime.MediaTypeNames.Application.Octet, name);
        }

        public ActionResult HttpUnauthorized()
        {
            //return new HttpUnauthorizedResult();
            return new HttpUnauthorizedResult(StringHelper.StringToISO_8859_1("無權限"));
        }

        public ActionResult JS()
        {
            // include
            // http://localhost:57683/actionresulttest/index

            return JavaScript("alert('test');");
        }
                
        public ActionResult JSON()
        {
            return Json(new { Name = "jon", Age = 18 }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Redirect()
        {
            //http://localhost:57683/actionresulttest/redirect
            //return Redirect("~/actionresulttest/index");

            return Redirect("https://www.google.com.tw/");
        }

        public ActionResult RedirectToAction()
        {
            //return RedirectToAction("Index");
            //return RedirectToAction("Index", "ActionResultTest");
            return RedirectToAction("TxtContent", "ActionResultTest", new { Name="test"});
        }

        public ActionResult StatusCode()
        {
            // http://qkxue.net/info/207714/MVC-httpstatuscoderesult-StatusDescription

            // 根据 http 协议，StatusDescription 是写在 http header 中的，默认所有header是用iso-8859-1编码的，但是中文实际是用uft8编码。所以就出现了乱码问题。

            //return new HttpStatusCodeResult(HttpStatusCode.BadRequest, StringHelper.StringToISO_8859_1("伺服器無法了解需求")); //400
            //return new HttpStatusCodeResult(HttpStatusCode.InternalServerError);    //500
            //return new HttpStatusCodeResult(HttpStatusCode.ServiceUnavailable);     //503

            return HttpNotFound();            
        }               
    }
}