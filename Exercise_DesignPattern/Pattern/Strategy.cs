using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DesignPattern.Pattern
{
    /*
     策略模式
     http://xyz.cinc.biz/2013/08/strategy-pattern.html


     */

    interface IStrategy
    {
        void Execute(int money);
    }

    class ConcreteStrategyA : IStrategy
    {
        public void Execute(int money)
        {
            double res = money * 0.8;
            Console.WriteLine("原價 {0}, 打8折 = {1}", money, res);
        }
    }

    class ConcreteStrategyB : IStrategy
    {
        public void Execute(int money)
        {
            double res = money * 0.7;
            Console.WriteLine("原價 {0}, 打7折 = {1}", money, res);
        }
    }

    // 用來維護策略物件的類別
    class CashContext
    {
        IStrategy _strategy; // 算法物件

        public CashContext(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void ExecuteStrategy(int money)
        {
            this._strategy.Execute(money);
        }
    }
}
