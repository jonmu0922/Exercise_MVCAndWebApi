using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Hosting;

namespace Exercise_MVCAndWebApi.Class.Helper
{
    public class LogHelper
    {
        public static void AddLog(string content)
        {
            using (StreamWriter file = 
                new StreamWriter(
                    HostingEnvironment.MapPath("~/app_data/log/" + DateTime.Now.ToString("yyyyMMdd") + ".txt") , 
                    true, 
                    Encoding.UTF8))
            {
                file.WriteLine(content);
            }
        }
    }
}