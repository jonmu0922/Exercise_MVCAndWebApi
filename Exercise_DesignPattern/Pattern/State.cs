using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DesignPattern.Pattern.State
{
    /*
    狀態模式
    http://xyz.cinc.biz/2013/07/state-pattern.html

        說明： 
        一物件有多個狀態，在不同狀態下有不同的行為。
        一般可能會用多個 if else 來處理這些分支行為。
        若使用狀態模式，則是將這些分支行為，提取出來，放到另外的 class 處理。
        也就是將 if else 拆開，改寫成一個分支一個 class。


    */
    // 玩家類別，有一個等級的屬性
    public class Player
    {
        public int level = 1; // 等級

        /* 狀態處理，一般用 if else 的寫法
        public void stateWork()
        {
            if (level >= 1 && level < 20)
            {
                Console.WriteLine("等級 {0} ({1})", level, "新手");
            }
            else if (level >= 20 && level < 50)
            {
                Console.WriteLine("等級 {0} ({1})", level, "老手");
            }
            else if (level >= 50 && level < 90)
            {
                Console.WriteLine("等級 {0} ({1})", level, "高手");
            }
            else if (level >= 90)
            {
                Console.WriteLine("等級 {0} ({1})", level, "神");
            }
        }
        */

        // 將狀態處理改為以下寫法 (狀態模式)
        private StateContext state;

        public Player()
        {
            // 初始化狀態處理的物件
            setStateContext(new ConcreteState001());
        }

        // 設定狀態處理的物件
        public void setStateContext(StateContext s)
        {
            state = s;
        }

        // 狀態處理，轉交由 StateContext 物件處理
        public void stateWork()
        {
            state.stateWork(this);
        }
    }

    // 狀態模式的抽象類別
    public abstract class StateContext
    {
        public abstract void stateWork(Player user);
    }

    // 等級 1~20
    public class ConcreteState001 : StateContext
    {
        public override void stateWork(Player user)
        {
            // 判斷是否符合狀態物件設定
            // 若不是設定下一個狀態物件處理
            if (user.level < 20)
            {
                Console.WriteLine("等級 {0} ({1})", user.level, "新手");
            }
            else
            {
                user.setStateContext(new ConcreteState050());
                user.stateWork();
            }
        }
    }

    // 等級 20~50
    public class ConcreteState050 : StateContext
    {
        public override void stateWork(Player user)
        {
            if (user.level < 50)
            {
                Console.WriteLine("等級 {0} ({1})", user.level, "老手");
            }
            else
            {
                user.setStateContext(new ConcreteState090());
                user.stateWork();
            }
        }
    }

    // 等級 50~90
    public class ConcreteState090 : StateContext
    {
        public override void stateWork(Player user)
        {
            if (user.level < 90)
            {
                Console.WriteLine("等級 {0} ({1})", user.level, "高手");
            }
            else
            {
                user.setStateContext(new ConcreteStateMAX());
                user.stateWork();
            }
        }
    }

    // 等級 90~
    public class ConcreteStateMAX : StateContext
    {
        public override void stateWork(Player user)
        {
            if (user.level >= 90)
            {
                Console.WriteLine("等級 {0} ({1})", user.level, "神");
            }
        }
    }
}
