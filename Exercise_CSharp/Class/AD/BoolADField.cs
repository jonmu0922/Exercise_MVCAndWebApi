using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercise_CSharp.AD
{
    public class BoolADField : BaseADField
    {
        public override string DataType()
        {
             return "bool";
        }        
    }
}