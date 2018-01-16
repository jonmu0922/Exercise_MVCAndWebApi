using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DesignPattern.Pattern.Bridge
{
    /*
    Bridge 橋接模式
    https://lightofhexagram.wordpress.com/2016/11/26/%E8%A8%AD%E8%A8%88%E6%A8%A1%E5%BC%8F-%E6%A9%8B%E6%8E%A5%E6%A8%A1%E5%BC%8F/ 
    */

    public interface IConsoleOutput
    {
        void WriteLine(string value);       
    }

    public class DefaultConsoleOutput : IConsoleOutput
    {
        public void WriteLine(string value)
        {
            Console.WriteLine("Default:" + value);
        }        
    }

    public class ColorfulConsoleOutput : IConsoleOutput
    {
        public void WriteLine(string value)
        {
            Console.WriteLine("Colorful:" + value);
        }       
    }

    public abstract class ILog
    {
        public abstract void WriteLog(string value);
        
    }
    public class ConcreteLog : ILog
    {
        private IConsoleOutput consoleOutput;

        public ConcreteLog(IConsoleOutput consoleOutput)
        {
            this.consoleOutput = consoleOutput;
        }
        public override void WriteLog(string value)
        {
            consoleOutput.WriteLine(value);
        }        
    }
}
