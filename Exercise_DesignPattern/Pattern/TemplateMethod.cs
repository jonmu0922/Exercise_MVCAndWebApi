using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DesignPattern.Pattern.TemplateMethod
{
    /*
    模板方法
    https://hk.saowen.com/a/e812e05e123f91b227acbfb14fd071da7164cd19b1ff8c812d02bbb1492c2a84
    http://e-troy.blogspot.tw/2015/02/c-design-pattern-template-method.html

    定義了一個演算法的步驟，並允許次類別為一個或多個步驟提供其實踐方式。讓次類別在不改變演算法架構的情況下，重新定義演算法中的某些步驟。 
    
    架構是準備一個抽象類別，將部分邏輯以具體方法以及具體構造子的形式實現，然後聲明一些抽象方法來迫使子類實現剩餘的邏輯。不同的子類可以以不同的方式實現這些抽象方法，從而對剩餘的邏輯有不同的實現。這就是模版方法模式的用意。
    其實，Template Method Pattern實際上是所有模式中最為常見的幾個模式之一。Template Method Pattern是基於繼承的代碼複用的基本技術，Template Method Pattern的結構和用法也是物件導向設計的核心。
    Template Method需要開發抽象類別和具體子類的設計師之間的協作。一個設計師負責給出一個演算法的輪廓和骨架，另一些設計師則負責給出這個演算法的各個邏輯步驟。代表這些具體邏輯步驟的方法稱做基本方法（primitive method）；而將這些基本法方法總匯起來的方法叫做模版方法（template method）。     

    */

    /// <summary>
    /// The 'AbstractClass' abstract class
    /// </summary>
    abstract class DataAccessObject
    {      
        public virtual void Connect()
        {
            Console.WriteLine("DataAccessObject Connect");
        }

        public abstract void Select();
        public abstract void Process();

        public virtual void Disconnect()
        {
            Console.WriteLine("DataAccessObject Disconnect");          
        }

        // The 'Template Method' 
        public void Run()
        {
            Connect();
            Select();
            Process();
            Disconnect();
        }
    }

    /// <summary>
    /// A 'ConcreteClass' class
    /// </summary>
    class Categories : DataAccessObject
    {
        public override void Select()
        {
            Console.WriteLine("Categories Select");
        }

        public override void Process()
        {
            Console.WriteLine("Categories Process");
        }
    }

    /// <summary>
    /// A 'ConcreteClass' class
    /// </summary>
    class Products : DataAccessObject
    {
        public override void Select()
        {
            Console.WriteLine("Products Select");
        }

        public override void Process()
        {
            Console.WriteLine("Products Process");
        }
    }
}
