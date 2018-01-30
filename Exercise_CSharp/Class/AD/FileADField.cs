using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercise_CSharp.AD
{
    public class FileADField : BaseADField
    {
        public override string DataType()
        {
             return "file";
        }

        public string FileType { get; set; }
    }
}