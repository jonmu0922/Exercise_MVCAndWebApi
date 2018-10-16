using Exercise_MVCAndWebApi.EF;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Hosting;
using System.Web.Http;

namespace Exercise_MVCAndWebApi.Controllers.api
{
    public class ApiTestController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Name(string name)
        {
            // http://localhost:57683/api/apitest/name?name=jon
            return Request.CreateResponse(HttpStatusCode.OK, "hello " + name);
        }

        [HttpPost]
        public HttpResponseMessage PostName([FromBody]string name)
        {
            // ref:https://hk.saowen.com/a/59887711bd30ac639247aec2e5c794143d1c3f5a72832c5084917749cd7a9075
            // 單一參數 webapi post
            // js post 過來要加上 = 
            //  axios.post('../api/apitest/PostName', '=' + this.name)
            return Request.CreateResponse(HttpStatusCode.OK, "hello " + name);
        }

        [HttpPost]
        public HttpResponseMessage PostNameAge(Temp temp)
        {
            // 多參數 webapi post
            // 使用class 來做binding 是最建議的方法
            string result = "";
            result += "hello " + temp.Name;
            result += temp.Age + "year old";

            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [HttpGet]
        public HttpResponseMessage ProcessTest()
        {
            // http://localhost:57683/api/apitest/ProcessTest
            // http://localhost/Exercise_MVCAndWebApi/api/apitest/ProcessTest

            //Process.Start("IExplore.exe");
            //System.Diagnostics.Process.Start("notepad.exe", "jonmu");



            //Process.Start(psi);

            string strFilePath = HostingEnvironment.MapPath("~/app_data/test.bat");

            string path = "C:\\Windows\\System32\\notepad.exe";
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.LoadUserProfile = true;
            psi.WorkingDirectory = strFilePath;
            psi.FileName = path;

            //System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo("cmd.exe");
            //psi.Arguments = "/c " + strFilePath;

            //psi.UseShellExecute = false;
            ////psi.UseShellExecute = true;
            //System.Diagnostics.Process proc = System.Diagnostics.Process.Start(psi);



            //Process.Start(strFilePath);

            //ProcessStartInfo startInfo = new ProcessStartInfo();
            //startInfo.CreateNoWindow = false;
            //startInfo.UseShellExecute = false;

            //startInfo.FileName = strFilePath;
            //startInfo.WindowStyle = ProcessWindowStyle.Hidden;

            //var processStartInfo = new ProcessStartInfo();
            //processStartInfo.WorkingDirectory = @"C:\Program Files (x86)\Microsoft SQL Server\140\Tools\Binn";
            //processStartInfo.FileName = "ssms.exe";
            //processStartInfo.RedirectStandardOutput = true;
            //processStartInfo.RedirectStandardInput = true;
            //processStartInfo.UseShellExecute = false;

            //// set additional properties     
            //Process proc = Process.Start(processStartInfo);
            ////proc.StandardInput.WriteLine("myExe.exe myargs1 myargs2 myargs3 ");
            ////// add this line to prevent your asp.net code die in the console
            ////proc.WaitForExit(5000);

            //System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Microsoft SQL Server\140\Tools\Binn\ManagementStudio\Ssms.exe");

            return Request.CreateResponse(HttpStatusCode.OK, "test");
        }
    }

    public class Temp
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
