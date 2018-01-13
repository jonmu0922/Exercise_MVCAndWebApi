using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DesignPattern.Pattern.Observer
{
    /*
    觀察者模式模式 
    Observer Pattern

    https://dotblogs.com.tw/joysdw12/2013/03/13/96531

    觀察者模式定義了物件之間的一對多關係，如此一來，當一個物件改變狀態，其他相依者都會收到通知並自動被更新

    報社 -> 訂報者
    */

    /// <summary>
    /// 主題
    /// </summary>
    public interface ISubject
    {
        void RegisterObserver(IObserver pObserver);
        void RemoveObserver(IObserver pObserver);
        void notifyObservers(string pContent);
    }

    /// <summary>
    /// 觀察者
    /// </summary>
    public interface IObserver
    {
        void Update(string pMessage);
    }

    /// <summary>
    /// 報社
    /// </summary>
    public class NewspaperOffice : ISubject
    {
        List<IObserver> lstObservers; // 使用List來存放觀察者名單

        public NewspaperOffice()
        {
            lstObservers = new List<IObserver>();
        }

        // 加入觀察者
        public void RegisterObserver(IObserver pObserver)
        {
            lstObservers.Add(pObserver);
        }

        // 移除觀察者
        public void RemoveObserver(IObserver pObserver)
        {
            if (lstObservers.IndexOf(pObserver) >= 0)
                lstObservers.Remove(pObserver);
        }

        // 發送通知給在監聽名單中的觀察者
        public void notifyObservers(string pContent)
        {
            foreach (IObserver observer in lstObservers)
            {
                observer.Update(pContent);
            }
        }

        // 訂閱報紙
        public void SubscribeNewspaper(IObserver pCustomer)
        {
            RegisterObserver(pCustomer);
        }

        // 取消訂閱報紙
        public void UnsubscribeNewspaper(IObserver pCustomer)
        {
            RemoveObserver(pCustomer);
        }

        // 發送新消息
        public void SendNewspaper(string pContent)
        {
            Console.WriteLine("Send News..");
            notifyObservers(pContent);
        }
    }

    /// <summary>
    /// 訂報者
    /// </summary>
    public class Customer : IObserver
    {
        public string MyName { private get; set; }

        public Customer(string pName)
        {
            MyName = pName;
        }

        // 更新最新消息
        public void Update(string pMessage)
        {
            Console.WriteLine("   {0} receive a new message:{1}", MyName, pMessage);
        }
    }
}
