using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_CSharp.Class.Helper
{
    public class FileHelper
    {
        public static string ReadFile(string path)
        {
            using (StreamReader file = new StreamReader(path, Encoding.Default))
            {
                return file.ReadToEnd();
            }
        }
    }
}
