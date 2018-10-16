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
            ZipHelper.ZipDir(@"D:\Deploy\temp\", @"D:\Deploy\test.zip");

            Console.ReadKey();

            /*
            ADHelper adhelper = new ADHelper();

            adhelper.XmlToADList(Environment.CurrentDirectory + @"\test.xml");
            */
        }
    }
}
