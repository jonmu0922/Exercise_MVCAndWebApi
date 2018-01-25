using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DesignPattern.Pattern.Interpreter
{
    /*
     解釋器模式
     用來解釋、直譯一種語言的方法。
     http://xyz.cinc.biz/2013/08/interpreter-pattern.html
    */

    /// <summary>
    /// 存放待解譯資料
    /// </summary>
    class Context
    {
        private string text;
        public string Text
        {
            get { return text; }
            set { text = value; }
        }
    }

    abstract class Expression
    {
        public string Interpret(Context context)
        {
            List<string> result = new List<string>();

            if (context.Text.Length > 0)
            {
                for (var i = 0; i < context.Text.Length; i++)
                {

                    result.Add(Excute(context.Text.Substring(i, 1)));
                }
            }
            return string.Join("", result);
        }

        public abstract string Excute(string str);
    }

    class TranslateUpperChinese : Expression
    {
        public override string Excute(string str)
        {
            switch (str)
            {
                case "0":
                    return "零";
                case "1":
                    return "壹";
                case "2":
                    return "貳";
                case "3":
                    return "參";
                case "4":
                    return "肆";
                case "5":
                    return "伍";
                case "6":
                    return "陸";
                case "7":
                    return "柒";
                case "8":
                    return "捌";
                case "9":
                    return "玖";               
                default:
                    return str;
            }
        }
    }

    class TranslateLowerChinese : Expression
    {
        public override string Excute(string str)
        {
            switch (str)
            {
                case "0":
                    return "〇";
                case "1":
                    return "一";
                case "2":
                    return "二";
                case "3":
                    return "三";
                case "4":
                    return "四";
                case "5":
                    return "五";
                case "6":
                    return "六";
                case "7":
                    return "七";
                case "8":
                    return "八";
                case "9":
                    return "九";
                default:
                    return str;
            }
        }
    }
}
