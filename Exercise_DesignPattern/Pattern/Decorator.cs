using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DesignPattern.Pattern.Decorator
{
    /*
    裝飾者模式
    http://hycleo.logdown.com/posts/255487-design-patterns-decorator-decorator-pattern
    http://xyz.cinc.biz/2013/05/decorator-pattern.html

    早餐店的例子
    https://dotblogs.com.tw/pin0513/archive/2010/01/04/12779.aspx

    裝飾者的聯想
    1. 銳利的 閃爍的 堅硬的 巨大的 大劍
    2. 鮭魚 豬排 蓋飯
    3. 火腿 起司 蛋 三明治
    4. 珍珠 椰果 粉條 奶茶
    5. 漢堡皮玩偶 貓(疑？

    可以分成兩塊來看
    1. 主體(大劍、蓋飯、三明治、奶茶、貓)
        * 擁有主要的功能及行為。
    2. 裝飾(銳利的、豬排、火腿、椰果、漢堡皮玩偶......)
        * 幫助補充或增加主體的功能及行為。
     
    裝飾者模式中有主要兩種角色

    1.Component 主物件
        * 擁有主要的功能及行為。
    2.DecoratorComponent 裝飾者物件
        * 幫助補充或增加主體的功能及行為。
    
    目的：可以動態的擴充主物件功能，理論上可以用無數層的裝飾者物件擴充主物件功能。
     */

    /// <summary>
    /// 食物抽像類別，定義了「被裝飾者」和「裝飾功能」要實做的方法
    /// </summary>
    public abstract class Food
    {
        public abstract string Description();

        /// <summary>
        /// 價錢
        /// </summary>
        public abstract int Cost();
    }   

    /// <summary>
    /// 被裝飾者
    /// </summary>
    public class Toast : Food
    {
        public override int Cost()
        {
            return 20;
        }

        public override string Description()
        {
            return "吐司";
        }
    }

    /// <summary>
    /// 抽象的裝飾者 => 配料
    /// </summary>
    public abstract class Batching : Food
    {
        public abstract override int Cost();        

        public abstract override string Description();        
    }

    /// <summary>
    /// 配料 => 加蛋
    /// </summary>
    public class Egg : Batching
    {
        Food _food;

        public Egg(Food food)
        {
            _food = food;
        }


        public override int Cost()
        {
            return _food.Cost() + 10;
        }

        public override string Description()
        {
            return _food.Description() + " 加蛋";
        }
    }

    /// <summary>
    /// 配料 => 培根
    /// </summary>
    public class Bacon : Batching
    {
        Food _food;

        public Bacon(Food food)
        {
            _food = food;
        }

        public override int Cost()
        {
            return _food.Cost() + 10;
        }

        public override string Description()
        {
            return _food.Description() + " 加培根";
        }
    }
}
