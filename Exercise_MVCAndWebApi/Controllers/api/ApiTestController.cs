using Exercise_MVCAndWebApi.EF;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
    }

    public class Temp
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
