using Exercise_DesignPattern.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simple Factory
            //Driver driver = new Driver(new TransportFactory());

            //driver.Dirve(TransportType.Bike);
            //driver.Dirve(TransportType.Scooter);

            // FactoryMethod
            //ITeaFactory factory1 = new BlackTeaFactory();
            //ITeaFactory factory2 = new GreenTeaFactory();

            //ITea tea = factory1.CreateTea();
            //tea.Make();

            //tea = factory2.CreateTea();
            //tea.Make();

            // Strategy
            //CashContext context = new CashContext(new ConcreteStrategyA());
            //context.ExecuteStrategy(100);

            //context = new CashContext(new ConcreteStrategyB());
            //context.ExecuteStrategy(100);

            //簡單抽象工廠模式 Simple Abstract Factory Pattern

            Console.WriteLine(new Exercise_DesignPattern.Pattern.SimpleAbstractFactoryPattern.Bike().GetType().ToString());
            Exercise_DesignPattern.Pattern.SimpleAbstractFactoryPattern.ITransport transport = 
                Exercise_DesignPattern.Pattern.SimpleAbstractFactoryPattern.TransportFactory.CreateTransport("Bike");

            transport.Drive();

            //transport = Exercise_DesignPattern.Pattern.SimpleAbstractFactoryPattern.TransportFactory.CreateTransport("Scooter");
            //transport.Drive();


            Console.ReadLine();

        }
    }
}
