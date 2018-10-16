using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_CSharp.Class.Helper
{
    public class ZipHelper
    {
        public static void ZipDir(string sourcedir, string targetpath)
        {
            FastZip oZipDir = new FastZip();

            if (Directory.Exists(sourcedir))
            {
                oZipDir.CreateZip(targetpath, sourcedir, true, "");                
            }           
        }

        public static void ZipDir(Stream output, string sourcedir, string targetpath)
        {
            //FastZip oZipDir = new FastZip();

            //if (Directory.Exists(sourcedir))
            //{
            //    oZipDir.CreateZip(output, targetpath, true, "", "");
            //}

            
        }
    }
}
