using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI.WebControls;

namespace Exercise_MVCAndWebApi.Controllers
{
    public class AuthTestController : Controller
    {        
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Models.Login model)
        {
            if (this.ModelState.IsValid)
            {
                //序列化user物件放到 auth cookie(預設 .ASPXAUTH) 裡面
                //FormsAuthentication.SetAuthCookie(
                //    JsonConvert.SerializeObject(model),
                //    false
                //);

                // reference
                // http://kevintsengtw.blogspot.tw/2013/11/aspnet-mvc.html

                var ticket = new FormsAuthenticationTicket(
                    version: 1,
                    name: model.Account,
                    issueDate: DateTime.Now,
                    expiration: DateTime.Now.AddMinutes(30),
                    isPersistent: true,
                    userData: "",
                    cookiePath: FormsAuthentication.FormsCookiePath
                );

                var encryptedTicket = FormsAuthentication.Encrypt(ticket);
                var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);               

                Response.Cookies.Add(cookie);

                return RedirectToAction("CheckAuth");
            }

            return View();
        }

        [Authorize]
        public ActionResult CheckAuth()
        {
            /*
            要使用 
             
            [Authorize] 
            
            Web.Confi 要有設定
            <authentication mode="Forms"></authentication>  or
            <authentication mode="Windows"></authentication>             
             
            */
            if (User.Identity.IsAuthenticated)
            {
                ViewBag.IsAuthenticated = User.Identity.IsAuthenticated;
                ViewBag.Name = User.Identity.Name;
            }
            else
            {
                ViewBag.IsAuthenticated = false;                
            }
            
            
            return View();
        }

        /// <summary>
        /// 登出
        /// </summary>
        /// <returns></returns>
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }        
    }
}