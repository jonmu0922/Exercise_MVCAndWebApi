using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DesignPattern.Pattern.Composite
{
    /*
    組合模式    
    數個物件之間，呈現一種樹狀結構。物件之間可以組合。
    => 樹狀目錄選單
    http://xyz.cinc.biz/2013/07/composite-pattern.html
    */

    // 選單元件抽像介面
    abstract class Menu
    {
        protected string _name;

        public Menu(string name)
        {
            this._name = name;
        }

        // 顯示資料
        public abstract void Display(int depth);
    }

    // 節點選單
    class CompositeMenu : Menu
    {
        private List<Menu> menu = new List<Menu>();

        public CompositeMenu(string name)
            : base(name)
        {
        }

        // 新增
        public void Add(Menu m)
        {
            menu.Add(m);
        }

        // 移除
        public void Remove(Menu m)
        {
            menu.Remove(m);
        }

        // 預設第0階
        public override void Display(int depth = 0)
        {
            Console.WriteLine(new String('-', depth) + this._name);

            foreach (Menu m in menu)
            {
                m.Display(depth + 1);
            }
        }
    }
}
