using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DesignPattern.Pattern.Proxy
{
    /*
    代理模式
    為其他物件提供一種代理以控制對這個物件的存取。
    https://dotblogs.com.tw/atowngit/2010/03/09/13956
    http://e-troy.blogspot.tw/2014/01/c-proxy-pattern.html

    用在哪些地方?

    遠端代理。隱藏一個物件存在於不同位址空間的事實。(ex .NET 的 WebService 應用)。
    虛擬代理。用來存放實體化需要很長時間的真實物件。(ex 網頁顯示文字圖在慢慢出來)。
    安全代理。控制真實物件存取的權限。
    參考代理。當調用真實物件時，代理可以計算真實物件被參考的次數，或是真實物件正在使用，請下個使用者稍待。
    */

    interface IMath
    {
        void Add(double x, double y);
        void Sub(double x, double y);
        void Mul(double x, double y);
        void Dev(double x, double y);
    }

    class Math : IMath
    {
        public void Add(double x, double y)
        {
            Console.WriteLine("Add:" + (x + y));
        }

        public void Dev(double x, double y)
        {
            Console.WriteLine("Dev:" + (x - y));
        }

        public void Mul(double x, double y)
        {
            Console.WriteLine("Mul:" + (x * y));
        }

        public void Sub(double x, double y)
        {
            Console.WriteLine("Sub:" + (x / y));
        }
    }

    class MathProxy : IMath
    {
        Math _math;
        public MathProxy()
        {
            _math = new Math();
        }
        public void Add(double x, double y)
        {
            _math.Add(x, y);
        }

        public void Dev(double x, double y)
        {
            _math.Dev(x, y);
        }

        public void Mul(double x, double y)
        {
            _math.Mul(x, y);
        }

        public void Sub(double x, double y)
        {
            _math.Sub(x, y);
        }
    }
}
