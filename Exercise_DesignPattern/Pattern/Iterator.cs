using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DesignPattern.Pattern.Iterator
{
    /*
    迭代器模式 
    迭代器提供一種方法來逐一訪問對象的元素，而不暴露其結構。 
    https://zh.wikipedia.org/wiki/%E8%BF%AD%E4%BB%A3%E5%99%A8%E6%A8%A1%E5%BC%8F
    https://hk.saowen.com/a/4eda341e25202f88ba24d50c86d096765ad29e7d38da5f999e36cc49f3178ada
    
    提供一種方法順序訪問一個聚合對象中的各個元素，而又不暴露該對象的內部表示。
                                                      ——《設計模式》GoF
    
    在System.Collections 命名空間裏面早已有了迭代器模式的實現。對於聚集接口和迭代器接口已經存在了，其中IEnumerator扮演的就是迭代器的角色     

    public interface IEnumerator
    {
        object Current { get;}
        bool MoveNext();
        void Reset();
    }

    IEnumerable則扮演的就是抽象聚集的角色，只有一個GetEnumerator()方法，如果集合對象需要具備迭代遍歷的功能，就必須實現該接口。

    public interface IEnumerable
    {
        IEumerator GetEnumerator();
    }

    */

    class DaysOfTheWeek : IEnumerable
    {
        string[] days = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

        public IEnumerator GetEnumerator()
        {
            foreach(var day in days)
                yield return day;            

            Console.Write("yield return");
        }
    }
}
