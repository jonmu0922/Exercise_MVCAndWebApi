using Exercise_DesignPattern.Pattern;
using Exercise_DesignPattern.Pattern.Decorator;
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

            //------------------------------------------------------------------------------------

            // FactoryMethod
            //ITeaFactory factory1 = new BlackTeaFactory();
            //ITeaFactory factory2 = new GreenTeaFactory();

            //ITea tea = factory1.CreateTea();
            //tea.Make();

            //tea = factory2.CreateTea();
            //tea.Make();

            //------------------------------------------------------------------------------------

            // Strategy
            //CashContext context = new CashContext(new ConcreteStrategyA());
            //context.ExecuteStrategy(100);

            //context = new CashContext(new ConcreteStrategyB());
            //context.ExecuteStrategy(100);

            //------------------------------------------------------------------------------------

            //簡單抽象工廠模式 Simple Abstract Factory Pattern
            //Console.WriteLine(new Exercise_DesignPattern.Pattern.SimpleAbstractFactoryPattern.Bike().GetType().ToString());
            //Exercise_DesignPattern.Pattern.SimpleAbstractFactoryPattern.ITransport transport = 
            //    Exercise_DesignPattern.Pattern.SimpleAbstractFactoryPattern.TransportFactory.CreateTransport("Bike");

            //transport.Drive();

            //transport = Exercise_DesignPattern.Pattern.SimpleAbstractFactoryPattern.TransportFactory.CreateTransport("Scooter");
            //transport.Drive();

            //------------------------------------------------------------------------------------            

            //Singleton

            //var s1 = Singleton.Instance();
            //var s2 = Singleton.Instance();

            //if (s1 == s2)
            //    Console.WriteLine("the same");

            //------------------------------------------------------------------------------------
            // 裝飾者模式

            Food t1 = new Toast();

            Console.WriteLine(t1.Description() + "$" + t1.Cost());

            Food t2 = new Toast();
            t2 = new Egg(t2);

            Console.WriteLine(t2.Description() + "$" + t2.Cost());

            Food t3 = new Toast();
            t3 = new Egg(t3);
            t3 = new Bacon(t3);

            Console.WriteLine(t3.Description() + "$" + t3.Cost());

            //------------------------------------------------------------------------------------

            Console.ReadLine();
        }
    }
}
