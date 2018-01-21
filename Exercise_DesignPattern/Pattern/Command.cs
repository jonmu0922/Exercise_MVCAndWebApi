using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DesignPattern.Pattern.Command
{
    /*
    命令模式
    https://zh.wikipedia.org/wiki/%E5%91%BD%E4%BB%A4%E6%A8%A1%E5%BC%8F#C#
    http://xyz.cinc.biz/2013/07/command-pattern.html

    它嘗試以物件來代表實際行動。命令物件可以把行動(action) 及其參數封裝起來，於是這些行動可以被：

    - 重複多次
    - 取消（如果該物件有實作的話）
    - 取消後又再重做

    這些都是現代大型應用程式所必須的功能，即「復原」及「重複」。除此之外，可以用命令模式來實作的功能例子還有：

    - 交易行為
    - 進度列
    - 精靈
    - 使用者介面按鈕及功能表項目
    - 執行緒 pool
    - 巨集收錄
    */

    /// <summary>
    /// 命令的界面
    /// 也可用 abstract
    /// </summary>
    interface ICommand
    {
        void Execute();
    }

    /// <summary>
    /// 實際執行命令的物件
    /// </summary>
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("The light is on");
        }

        public void TurnOff()
        {
            Console.WriteLine("The light is off");
        }
    }

    /// <summary>
    /// 開燈命令
    /// </summary>
    public class FlipUpCommand : ICommand
    {
        private Light _light;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="light">執行命令的物件</param>
        public FlipUpCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOn();
        }
    }
    
    /// <summary>
    /// 關燈命令
    /// </summary>
    public class FlipDownCommand : ICommand
    {
        private Light _light;

        public FlipDownCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOff();
        }
    }

    /// <summary>
    /// invoker 發出命令的類別 
    /// </summary>
    class Switch
    {
        private List<ICommand> _commands = new List<ICommand>();

        public void StoreAndExecute(ICommand command)
        {
            _commands.Add(command);
            command.Execute();
        }
    }
}
