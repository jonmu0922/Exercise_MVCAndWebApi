using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DesignPattern.Pattern
{
    /*
    工廠方法模式
    https://dotblogs.com.tw/joysdw12/2013/09/12/design-pattern-factory-method-pattern 

    當要增加一個 Tea 類型時，只要新增 Tea 和 Factory
    若是使用簡單工廠就必需要修改 Factory Create 的 Method
    */
    interface ITea
    {
        void Make();
    }
    class GreenTea : ITea
    {
        public void Make()
        {
            Console.WriteLine("I am GreenTea");
        }
    }

    class BlackTea : ITea
    {
        public void Make()
        {
            Console.WriteLine("I am BlackTea");
        }
    }

    interface ITeaFactory
    {
        ITea CreateTea();
    }

    class GreenTeaFactory : ITeaFactory
    {
        public ITea CreateTea()
        {
            return new GreenTea();
        }
    }

    class BlackTeaFactory : ITeaFactory
    {
        public ITea CreateTea()
        {
            return new BlackTea();
        }
    }

    
}
