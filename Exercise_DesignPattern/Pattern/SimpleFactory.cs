using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DesignPattern.Pattern
{
    /*
    簡單工廠模式
    https://dotblogs.com.tw/joysdw12/archive/2013/06/23/design-pattern-simple-factory-pattern.aspx
         
    新增一個 Transport 時，除 Transport 本身，再修改 Factory 的 Create method

    */

    interface ITransport
    {
        void Drive();
    }

    class Bike : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("Bike Drive");
        }
    }

    class Scooter : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("Scooter Drive");
        }
    }

    class TransportFactory
    {
        public ITransport CreateTransport(TransportType type)
        {
            ITransport transport = null;

            switch (type)
            {
                case TransportType.Bike:
                    transport = new Bike();
                    break;
                case TransportType.Scooter:
                    transport = new Scooter();
                    break;
            }
            return transport;
        }
    }

    class Driver
    {
        TransportFactory _factory;

        public Driver(TransportFactory factory)
        {
            _factory = factory;
        }

        public void Dirve(TransportType type)
        {
            ITransport transport = _factory.CreateTransport(type);
            transport.Drive();
        }
    }

    enum TransportType
    {
        Bike,
        Scooter
    }
}
