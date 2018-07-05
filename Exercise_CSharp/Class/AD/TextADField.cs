using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercise_CSharp.AD
{
    public class TextADField : BaseADField
    {
        public override string DataType()
        {
            return "string";
        }
    }
}