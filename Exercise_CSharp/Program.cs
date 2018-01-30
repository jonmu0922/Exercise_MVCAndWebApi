using Exercise_CSharp.Class.AD;
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
            ADHelper adhelper = new ADHelper();

            adhelper.XmlToADList(Environment.CurrentDirectory + @"\test.xml");
            

            Console.ReadKey();
        }
    }
}
