using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DesignPattern.Pattern.Adapter
{
    /*
    通過轉換已經存在類別的接口以適應而不改變它。
    Adapter分成兩種：
    繼承 (Class way)
    組合 (Object way)

    https://ithelp.ithome.com.tw/articles/10194158?sc=iThelpR
    http://www.aspxhtml.com/post-426
    */

    /// <summary>
    /// Target
    /// </summary>
    interface IThreeHole
    {
        void Request();
    }

    /// <summary>
    /// Adaptee 適配者
    /// </summary>
    class TwoHole
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Two Hole");
        }
    }

    /// <summary>
    /// Adapter
    /// 繼承 (Class way)
    /// </summary>
    class PowerAdapter : TwoHole, IThreeHole
    {
        public void Request()
        {
            this.SpecificRequest();
        }
    }

    class ThreeHole
    {
        public virtual void Request()
        {
            Console.WriteLine("Three Hole");
        }
    }

    /// <summary>
    /// Adapter
    /// 組合 (Object way)
    /// </summary>
    class PowerAdapter2 : ThreeHole
    {
        TwoHole _twohole = new TwoHole();

        public override void Request()
        {
            _twohole.SpecificRequest();
        }        
    }
}
