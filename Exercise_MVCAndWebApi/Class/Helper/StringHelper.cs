using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercise_MVCAndWebApi.Class.Helper
{
    public class StringHelper
    {
        /// <summary>
        /// 转换为ISO_8859_1
        /// </summary>
        /// <param name="srcText"></param>
        /// <returns></returns>
        public static string StringToISO_8859_1(string srcText)
        {
            string dst = "";
            char[] src = srcText.ToCharArray();
            for (int i = 0; i < src.Length; i++)
            {
                string str = @"&#" + (int)src[i] + ";";
                dst += str;
            }
            return dst;
        }

        /// <summary>
        /// 转换为原始字符串
        /// </summary>
        /// <param name="srcText"></param>
        /// <returns></returns>
        public static string ISO_8859_1ToString(string srcText)
        {
            string dst = "";
            string[] src = srcText.Split(';');
            for (int i = 0; i < src.Length; i++)
            {
                if (src[i].Length > 0)
                {
                    string str = ((char)int.Parse(src[i].Substring(2))).ToString();
                    dst += str;
                }
            }
            return dst;
        }
    }
}