using Exercise_MVCAndWebApi.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Exercise_MVCAndWebApi.Controllers.api
{
    public class EFTestController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage UserList()
        {
            // http://localhost:57683/api/EFTest/UserList

            using (var context = new TestContext())
            {
                return Request.CreateResponse(HttpStatusCode.OK, context.SysUser.ToList());
            }
        }

        [HttpGet]
        public HttpResponseMessage AddUser(string name,int age)
        {
            //http://localhost:57683/api/EFTest/AddUser?name=test&age=12

            using (var context = new TestContext())
            {
                SysUser user = new SysUser() { Name = name, Age = age };

                context.SysUser.Add(user);
                context.SaveChanges();

                return Request.CreateResponse(HttpStatusCode.OK, user);
            }
        }
    }
}
