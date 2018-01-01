using Exercise_MVCAndWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Exercise_MVCAndWebApi.Controllers
{
    public class FormTestController : Controller
    {
        // GET: FormTest
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(UserModel user)
        {
            // 一般 form 驗證
            if (this.ModelState.IsValid)
            {
                if (user.Name.Length > 5)
                    ModelState.AddModelError("Name", "姓名長度超過限制");   // 自己加入 ModelError，ModelState.IsValid 會變成 false

                // 再檢查一次
                if (this.ModelState.IsValid)
                    return View("Complete"); 
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AjaxAddUser(UserModel user)
        {
            // 透過AJAX接收ModelState Errors顯示於對應欄位中
            // https://dotblogs.com.tw/wasichris/2015/03/11/150705
            if (this.ModelState.IsValid)
            {
                if (user.Name.Length > 5)
                    ModelState.AddModelError("Name", "姓名長度超過限制");   // 自己加入 ModelError，ModelState.IsValid 會變成 false               

                // 再檢查一次
                if (!this.ModelState.IsValid)
                {                    
                    return Json(
                        new
                        {
                            Status = false,
                            Errors = ModelState.Where(x => x.Value.Errors.Count > 0)
                                .ToDictionary(k => k.Key, k => k.Value.Errors.Select(e => e.ErrorMessage).ToArray())
                        }                        
                    );
                }                    
            }

            return Json(new { Status = true});
        }
    }
}