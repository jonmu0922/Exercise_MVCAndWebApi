using Exercise_DesignPattern.Pattern;
using Exercise_DesignPattern.Pattern.AbstractFactory;
using Exercise_DesignPattern.Pattern.Adapter;
using Exercise_DesignPattern.Pattern.Bridge;
using Exercise_DesignPattern.Pattern.Builder;
using Exercise_DesignPattern.Pattern.Composite;
using Exercise_DesignPattern.Pattern.Decorator;
using Exercise_DesignPattern.Pattern.Observer;
using Exercise_DesignPattern.Pattern.Prototype;
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

            //Food t1 = new Toast();

            //Console.WriteLine(t1.Description() + "$" + t1.Cost());

            //Food t2 = new Toast();
            //t2 = new Egg(t2);

            //Console.WriteLine(t2.Description() + "$" + t2.Cost());

            //Food t3 = new Toast();
            //t3 = new Egg(t3);
            //t3 = new Bacon(t3);

            //Console.WriteLine(t3.Description() + "$" + t3.Cost());

            //------------------------------------------------------------------------------------
            // 觀察者模式

            //NewspaperOffice newspaper = new NewspaperOffice();

            //Customer c1 = new Customer("C1");
            //Customer c2 = new Customer("C2");

            //newspaper.SubscribeNewspaper(c1);
            //newspaper.SubscribeNewspaper(c2);

            //newspaper.SendNewspaper("Hello world");

            //newspaper.RemoveObserver(c1);

            //newspaper.SendNewspaper("Hello world2");
            //------------------------------------------------------------------------------------

            //------------------------------------------------------------------------------------
            // Abstract Factory
            //IFactory factory = new SqlServerFactory();
            //IUser user = factory.CreateUser();

            //user.InsertUser("jon");

            //------------------------------------------------------------------------------------
            // Prototype

            //Resume r1 = new Resume() { Name = "jon", Age = 28};
            //r1.SetWork(new DateTime(1900, 1, 1),"abc");            

            //Resume r2 = (Resume)r1.Clone();

            //r2.Name = "jon2";
            //r2.Age = 29;
            //r2.SetWork(new DateTime(2000, 1, 1), "def");            

            //Resume r3 = (Resume)r1.Clone();

            //r3.Name = "jon3";
            //r3.Age = 30;
            //r3.SetWork(new DateTime(2001, 1, 1), "def");

            //r1.Display();
            //r2.Display();
            //r3.Display();

            //Console.WriteLine("");

            //Resume_Deep r4 = new Resume_Deep() { Name = "jon4", Age = 28 };
            //r4.SetWork(new DateTime(1900, 1, 1), "abc");

            //Resume_Deep r5 = (Resume_Deep)r4.Clone();

            //r5.Name = "jon5";
            //r5.Age = 29;
            //r5.SetWork(new DateTime(2000, 1, 1), "def");

            //Resume_Deep r6 = (Resume_Deep)r4.Clone();

            //r6.Name = "jon6";
            //r6.Age = 30;
            //r6.SetWork(new DateTime(2001, 1, 1), "def");

            //r4.Display();
            //r5.Display();
            //r6.Display();

            //------------------------------------------------------------------------------------
            // Builder

            //VehicleBuilder builder;

            //// Create shop with vehicle builders
            //Shop shop = new Shop();

            //// Construct and display vehicles          
            //builder = new CarBuilder();
            //shop.Construct(builder);
            //builder.Vehicle.Show();

            //builder = new MotorCycleBuilder();
            //shop.Construct(builder);
            //builder.Vehicle.Show();

            //------------------------------------------------------------------------------------
            // Bridge 
            //ConcreteLog log1 = new ConcreteLog(new DefaultConsoleOutput());
            //ConcreteLog log2 = new ConcreteLog(new ColorfulConsoleOutput());

            //log1.WriteLog("log1");
            //log2.WriteLog("log2");

            //------------------------------------------------------------------------------------
            // Adapter
            //PowerAdapter p1 = new PowerAdapter();
            //PowerAdapter2 p2 = new PowerAdapter2();

            //p1.Request();
            //p2.Request();

            //------------------------------------------------------------------------------------
            // Composite

            CompositeMenu root = new CompositeMenu("公司");

            CompositeMenu office1 = new CompositeMenu("第一處");
            office1.Add(new CompositeMenu("第一科"));
            office1.Add(new CompositeMenu("第二科"));
            CompositeMenu office2 = new CompositeMenu("第二處");
            office2.Add(new CompositeMenu("第四科"));
            office2.Add(new CompositeMenu("第五科"));
            office2.Add(new CompositeMenu("第六科"));

            root.Add(office1);
            root.Add(office2);

            root.Display();

            //------------------------------------------------------------------------------------

            Console.ReadLine();
        }
    }
}
