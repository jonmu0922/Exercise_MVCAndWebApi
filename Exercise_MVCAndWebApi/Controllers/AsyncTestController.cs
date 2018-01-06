using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using Dapper;
using System.Configuration;

namespace Exercise_MVCAndWebApi.Controllers
{
    public class AsyncTestController : Controller
    {
        public async Task<ActionResult> Index()
        {
            // http://localhost:57683/asynctest/index

            //https://dotblogs.com.tw/kylessukaichang/2014/06/14/145551
            //建議使用非同步的情境
            //第一、大量下載網路資源(network - bound)或者大量的IO存取(I / O - bound)，而不是大量使用中央處理器的運算能力(CPU - bound)。
            //第二、經由測試結果得知被鎖定的執行緒是IIS的效能瓶頸。
            //第三、以平行處理為優先考量，而不是以簡化程式碼為優先考量。
            //第四、提供一個機制協助ASP.Net MVC的使用者可以在執行時期中途取消一個必須耗費冗長時間執行的作業。

            //http://vito-note.blogspot.tw/2013/03/asynchronous-controller.html
            //  因為當非同步作業執行時，原先的執行緒會被釋放交還給 IIS ，讓它可以繼續處理其他用戶端的請求。 等到非同步作業執行結束，再將工作交還給 IIS 處理。

            using (var reader = System.IO.File.OpenText(HostingEnvironment.MapPath("~/app_data/test.txt")))
            {
                string content = await reader.ReadToEndAsync();

                System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
                byte[] bytes = encoding.GetBytes(content);

                return File(bytes, System.Net.Mime.MediaTypeNames.Application.Octet, "test.txt");
            }         
        }

        public ActionResult Dapper()
        {
            // http://localhost:57683/asynctest/dapper

            string sql = "select * from sysuser";

            using (var cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
            {
                var users = cn.Query<Models.User>(sql);

                return View(users);
            }
        }

        public async Task<ActionResult> DapperAsync()
        {
            // http://localhost:57683/asynctest/dapperasync

            string sql = "select * from sysuser";

            using (var cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
            {
                var users = await cn.QueryAsync<Models.User>(sql);

                return View("dapper", users);
            }
        }
    }
}