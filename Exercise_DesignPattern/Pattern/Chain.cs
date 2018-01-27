using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DesignPattern.Pattern.Chain
{
    /*
    責任鍊模式
    http://xyz.cinc.biz/2013/07/chain-of-responsibility-pattern.html

    有幾個物件都能處理某種請求，但處理的能範圍(權限)不同，
    當這個物件沒有處理的權限時，能夠將這個請求，傳遞給下一個物件繼續處理。
    */

    /// <summary>
    /// 管理者處理事假申請的抽象類別
    /// </summary>
    abstract class ManagerHandler
    {
        protected string name;
        protected ManagerHandler upManager; // 上一級的管理者

        public ManagerHandler(string name)
        {
            this.name = name;
        }

        // 設定上一級的管理者
        public void SetUpManager(ManagerHandler upManager)
        {
            this.upManager = upManager;
        }

        // 事假處理
        abstract public void RequestPersonalLeave(LeaveRequest leaveRequest);
    }

    /// <summary>
    /// 經理
    /// </summary>
    class Manager : ManagerHandler
    {
        public Manager(string name) : base(name) { }

        public override void RequestPersonalLeave(LeaveRequest leaveRequest)
        {
            if (leaveRequest.DayNum <= 2)
            {
                // 2天以內，經理可以批准
                Console.WriteLine("經理 {0} 已批准 {1}{2}天的事假", this.name, leaveRequest.Name, leaveRequest.DayNum);
            }
            else
            {
                // 超過2天，轉呈上級
                if (null != upManager)
                {
                    upManager.RequestPersonalLeave(leaveRequest);
                }
            }
        }
    }

    /// <summary>
    /// 協理
    /// </summary>
    class Director : ManagerHandler
    {
        public Director(string name) : base(name) { }

        public override void RequestPersonalLeave(LeaveRequest leaveRequest)
        {
            if (leaveRequest.DayNum <= 5)
            {
                // 5天以內，經理可以批准
                Console.WriteLine("協理 {0} 已批准 {1}{2}天的事假", this.name, leaveRequest.Name, leaveRequest.DayNum);
            }
            else
            {
                // 超過5天，轉呈上級
                if (null != upManager)
                {
                    upManager.RequestPersonalLeave(leaveRequest);
                }
            }
        }
    }

    /// <summary>
    /// 總經理
    /// </summary>
    class GeneralManager : ManagerHandler
    {
        public GeneralManager(string name) : base(name) { }

        public override void RequestPersonalLeave(LeaveRequest leaveRequest)
        {
            if (leaveRequest.DayNum <= 7)
            {
                // 7天以內，總經理批准
                Console.WriteLine("總經理 {0} 已批准 {1}{2}天的事假", this.name, leaveRequest.Name, leaveRequest.DayNum);
            }
            else
            {
                // 超過7天以上，再深入了解原因
                Console.WriteLine("總經理 {0} 要再了解 {1}{2}天的事假原因", this.name, leaveRequest.Name, leaveRequest.DayNum);
            }
        }
    }


    /// <summary>
    /// 假單
    /// </summary>
    class LeaveRequest
    {
        // 姓名
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // 天數
        private int dayNum;
        public int DayNum
        {
            get { return dayNum; }
            set { dayNum = value; }
        }
    }
}
