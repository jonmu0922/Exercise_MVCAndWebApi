using Exercise_CSharp.AD;
using Exercise_CSharp.Class.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise_CSharp.Class.AD
{
    public class ADHelper
    {
        public List<BaseADField> XmlToADList(string path)
        {
            List<BaseADField> list = new List<BaseADField>();

            // parse xml
            XElement el = XElement.Parse(FileHelper.ReadFile(path));

            foreach (var e in el.Elements())
            {
                Console.WriteLine(e.Name + "=" + e.Value);

                foreach (var a in e.Attributes())
                {
                    Console.WriteLine(" " + a.Name + "=" + a.Value);
                }                                   
            }

            return list;
        }

        BaseADField MapAD(XElement el)
        {
            BaseADField result = null;
            switch (el.Attributes("DataType").First().Value)
            {
                case "string":
                    result = TextADMap(el);
                    break;
            }

            return result;
        }

        TextADField TextADMap(XElement el)
        {
            TextADField result = new TextADField();

            result.Name = el.Value; 
            result.IsRequired = el.Attributes("IsRequired").First().Value == "true";

            return result;
        }        
    }
}
