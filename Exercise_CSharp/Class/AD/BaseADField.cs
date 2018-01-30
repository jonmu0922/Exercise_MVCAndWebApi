using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercise_CSharp.AD
{
    public abstract class BaseADField
    {
        public string Name { get; set; }
        public bool IsRequired { get; set; }
        public string Value { get; set; }


        public abstract string DataType();
    }
}