using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DesignPattern.Pattern.Facade
{
    /*
    主要是將眾多Class重新包裝成一個更好用的Class
    封裝商業邏輯並提供簡單介面，以達到易使用、可讀性、減少依賴的目的

    http://gyanendushekhar.com/2016/08/21/facade-design-pattern-c/
    */

    class Light
    {
        public void SwitchOn()
        {
            Console.WriteLine("Light - SwitchOn");
        }

        public void SwitchOff()
        {
            Console.WriteLine("Light - SwitchOff");
        }
    }

    class AirConditioner
    {
        public void SwitchOn()
        {
            Console.WriteLine("Air Conditioner - SwitchOn");
        }

        public void SwitchOff()
        {
            Console.WriteLine("Air Conditioner - SwitchOff");
        }
    }

    class HomeFacade
    {
        Light light = new Light();
        AirConditioner airconditioner = new AirConditioner();

        public void LeaveHome()
        {
            light.SwitchOff();
            airconditioner.SwitchOff();
        }

        public void ArriveHome()
        {
            light.SwitchOn();
            airconditioner.SwitchOn();
        }
    }
}
