using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DesignPattern.Pattern.SimpleAbstractFactoryPattern
{
    /*
     簡單抽象工廠模式 Simple Abstract Factory Pattern
     http://blog.amowu.com/2009/08/factory-pattern.html

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
            classname = AssemblyName + "." + classname;

            //todo:Reflection 錯誤
            return (ITransport)Assembly.Load(AssemblyName).CreateInstance(classname);
            
        }
    }
}
