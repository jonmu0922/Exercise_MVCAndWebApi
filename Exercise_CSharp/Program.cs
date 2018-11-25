using Exercise_CSharp.Class.AD;
using Exercise_CSharp.Class.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now.AddSeconds(3600);

            int timeStamp = Convert.ToInt32(
                now.Subtract(new DateTime(1970, 1, 1)).TotalSeconds
            );

            Console.WriteLine(timeStamp);

            DateTime gtm = (new DateTime(1970, 1, 1)).AddSeconds(Convert.ToInt32(timeStamp));

            Console.WriteLine(gtm);
            
            Console.ReadKey();

            /*
            ZipHelper.ZipDir(@"D:\Deploy\temp\", @"D:\Deploy\test.zip");

            Console.ReadKey();
            */
            /*
            ADHelper adhelper = new ADHelper();

            adhelper.XmlToADList(Environment.CurrentDirectory + @"\test.xml");
            */
        }
    }
}
