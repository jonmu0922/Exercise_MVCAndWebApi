using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercise_CSharp.AD
{
    public class UrlADField : BaseADField
    {
        public override string DataType()
        {
             return "url";
        }

        public bool IsOpenBlank { get; set; }
    }
}