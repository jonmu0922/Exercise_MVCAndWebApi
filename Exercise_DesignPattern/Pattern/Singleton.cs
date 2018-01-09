using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DesignPattern.Pattern
{
    // Singleton
    // http://www.dofactory.com/net/singleton-design-pattern

    class Singleton
    {
        static Singleton _instance;

        // 設為 protected 後
        // 就不能使用 new Singleton()
        protected Singleton()
        {
        }

        public static Singleton Instance()
        {           
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }
    }
}
