using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DesignPattern.Pattern.SimpleAbstractFactoryPattern
{
    /*
     簡單抽象工廠模式 Simple Abstract Factory Pattern
     http://blog.amowu.com/2009/08/factory-pattern.html

    用 Reflection 解決實作原 Simple Factory Pattern 需要修改 switch case 問題
    Reflection(反射)，它可以直接依照 class 的名稱來實體化類別
    */


    interface ITransport
    {
        void Drive();
    }

    class Bike : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("Bike Drive");
        }
    }

    class Scooter : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("Scooter Drive");
        }
    }

    class TransportFactory
    {
        private static readonly string AssemblyName = "Exercise_DesignPattern.Pattern.SimpleAbstractFactoryPattern";

        public static ITransport CreateTransport(string classname)
        {
            // 先找出 Assembly FullName
            //Debug.WriteLine((typeof(ITransport).Assembly).FullName); 
            // output => Exercise_DesignPattern, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
            
            string assemblyname = "Exercise_DesignPattern, Version = 1.0.0.0, Culture = neutral, PublicKeyToken = null";

            classname = "Exercise_DesignPattern.Pattern.SimpleAbstractFactoryPattern" + "." + classname;

            return (ITransport)Assembly.Load(assemblyname).CreateInstance(classname);          
        }
    }
}
