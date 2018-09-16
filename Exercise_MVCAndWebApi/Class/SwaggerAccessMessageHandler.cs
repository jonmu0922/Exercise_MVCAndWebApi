using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Configuration;
using System.Linq;

namespace Exercise_MVCAndWebApi.Class
{
    public class SwaggerAccessMessageHandler : DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            string currentip = HttpContext.Current.Request.UserHostAddress;
            string[] ips = ConfigurationManager.AppSettings["AllowAccessSwaggerIP"].Split(';');

            //http://localhost/Exercise_MVCAndWebApi/swagger/ui/index
            //http://127.0.0.1/Exercise_MVCAndWebApi/swagger/ui/index

            if (IsSwagger(request) && !ips.Contains(currentip))          
            {
                //HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.Redirect);

                //// Redirect to login URL
                //string uri = string.Format("{0}://{1}", request.RequestUri.Scheme, request.RequestUri.Authority);
                //response.Headers.Location = new Uri(uri);

                //return Task.FromResult(response);

                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.Unauthorized);
                response.Content = new StringContent("ip not allow");

                return Task.FromResult(response);
            }

            return base.SendAsync(request, cancellationToken);
        }

        private bool IsSwagger(HttpRequestMessage request)
        {
            return request.RequestUri.PathAndQuery.Contains("/swagger");
        }
    }
}