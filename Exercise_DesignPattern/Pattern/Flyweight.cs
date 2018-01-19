using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DesignPattern.Pattern
{
    /*
    Flyweight 享元模式
    https://ithelp.ithome.com.tw/articles/10195427
    https://www.zybuluo.com/coder-pig/note/653571

    定義
    享元模式可在儲存和取出共用的物件、狀態等資訊。目的在於減少頻繁建立物件所消耗的資源。(WIKI)

    享元模式使用的時機如下：

    共享對像會頻繁的建立，而且每次建立需耗費可觀的資源
    共享對像適合為獨立且輕量的的小元素，且不會由本身來改變其狀態和資料
    提供介面讓外部程式改變其狀態和資料
    網站的暫存資料很適合將其作為Flyweight物件存放並共享給整個網站使用，因為暫存資料一般有以下特性：

    變動性小
    因資料共用性，一般習慣將暫存以小範圍管理之方式建立
    注意享元模式(Flyweight)為Structural design pattern而非Creational design pattern，
    它通常會搭配工廠模式(Factory)，由工廠提供資料，而Flyweight提供一個共享的結構。
    */

    enum PokerEnum
    {
        Spade = 0,
        Heart,
        Clud,
        Diamond
    }

    /// <summary>
    /// 撲克牌 享元抽像物件
    /// </summary>
    abstract class Card
    {
        public abstract void ShowCard(string num);
    }

    
    /// <summary>
    /// 黑桃
    /// </summary>
    class SpadeCard : Card
    {
        public override void ShowCard(string num)
        {
            Console.WriteLine("黑桃" + num);
        }
    }

    /// <summary>
    /// 紅心
    /// </summary>
    class HeartCard : Card
    {
        public override void ShowCard(string num)
        {
            Console.WriteLine("紅心" + num);
        }
    }

    /// <summary>
    /// 梅花
    /// </summary>
    class CludCard : Card
    {
        public override void ShowCard(string num)
        {
            Console.WriteLine("梅花" + num);
        }
    }

    /// <summary>
    /// 方塊
    /// </summary>
    class DiamondCard : Card
    {
        public override void ShowCard(string num)
        {
            Console.WriteLine("方塊" + num);
        }
    }

    /// <summary>
    /// 享元工廠
    /// </summary>
    class PokerFactory
    {
        Hashtable hashtable = new Hashtable();

        public Card GetCard(PokerEnum type)
        {
            if (hashtable.Contains(type.ToString()))
                return (Card)hashtable[type.ToString()];

            Console.WriteLine("不存在，新建" + type.ToString());

            switch (type)
            {
                case PokerEnum.Spade:
                    hashtable.Add(type.ToString(), new SpadeCard());
                    break;
                case PokerEnum.Heart:
                    hashtable.Add(type.ToString(), new HeartCard());
                    break;
                case PokerEnum.Clud:
                    hashtable.Add(type.ToString(), new CludCard());
                    break;
                case PokerEnum.Diamond:
                    hashtable.Add(type.ToString(), new DiamondCard());
                    break;
            }

            return (Card)hashtable[type.ToString()];
        }
    }
}
