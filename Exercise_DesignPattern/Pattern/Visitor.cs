using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DesignPattern.Pattern.Visitor
{
    /*
    訪問者模式
    https://hk.saowen.com/a/7243b684f372d725d41abc897b2ac85380ef9f54d24e4ef3f8b21a6396c11987 
    http://www.cnblogs.com/saville/archive/2012/07/10/2584396.html
    http://xyz.cinc.biz/2013/08/visitor-pattern.html

        當一個「物件結構」中的「元素」幾乎不會異動，但這些「元素的行為」常會增減，則適合用訪問者模式。
    訪問者模式是將「元素的行為」，提取出來，每一種行為做成一個 「Visitor(訪問者) 物件」，
    每一個 「Visitor(訪問者) 物件」，都能依據不同的「元素」，對應到不同的行為結果。
    */

    /// <summary>
    /// 抽象節點角色（Element）
    /// </summary>
    abstract class Emploree
    {
        public string Name { get; set; }
        protected Emploree() { }
        public Emploree(string name)
        {
            Name = name;
        }
        public abstract void Accept(Visitor visitor);
    }

    /// <summary>
    /// 具體節點角色（ConcreteElement）
    /// </summary>
    class Manager : Emploree
    {
         public Manager(string name)
         {
             Name = name;
         }

         public override void Accept(Visitor visitor)
         {
             visitor.Visit(this);
         }
     }

    /// <summary>
    /// 具體節點角色（ConcreteElement）
    /// </summary>
    class Chairman : Emploree
    {
        public Chairman(string name)
        {
            Name = name;
        }
        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }

    /// <summary>
    /// 抽象訪問者角色（Vistor）
    /// </summary>
    abstract class Visitor
    {
        public abstract void Visit(Manager manager);
        public abstract void Visit(Chairman chairman);
    }

    /// <summary>
    /// 具體訪問者角色（ConcreteVistor）
    /// </summary>
    class Salary : Visitor
    {
        public override void Visit(Manager manager)
        {
            Console.WriteLine("Manager salary is 100,000");
        }

        public override void Visit(Chairman chairman)
        {
            Console.WriteLine("Chairman salary is 1000,000");
        }
    }

    /// <summary>
    /// 結構對象角色（ObjectStructure）
    /// </summary>
    class CompanyStructure
    {
        public List<Emploree> Elements { get; set; }

        public CompanyStructure()
        {
            this.Elements = new List<Emploree>();
        }

        public void Accept(Visitor visitor)
        {
            foreach (Emploree e in Elements)
                e.Accept(visitor);
        }

    }
}
