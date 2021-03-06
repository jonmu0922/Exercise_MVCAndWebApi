﻿using Exercise_DesignPattern.Pattern;
using Exercise_DesignPattern.Pattern.AbstractFactory;
using Exercise_DesignPattern.Pattern.Adapter;
using Exercise_DesignPattern.Pattern.Bridge;
using Exercise_DesignPattern.Pattern.Builder;
using Exercise_DesignPattern.Pattern.Composite;
using Exercise_DesignPattern.Pattern.Decorator;
using Exercise_DesignPattern.Pattern.Facade;
using Exercise_DesignPattern.Pattern.Interpreter;
using Exercise_DesignPattern.Pattern.Iterator;
using Exercise_DesignPattern.Pattern.Mediator;
using Exercise_DesignPattern.Pattern.Memento;
using Exercise_DesignPattern.Pattern.Observer;
using Exercise_DesignPattern.Pattern.Prototype;
using Exercise_DesignPattern.Pattern.Proxy;
using Exercise_DesignPattern.Pattern.State;
using Exercise_DesignPattern.Pattern.TemplateMethod;
using Exercise_DesignPattern.Pattern.Visitor;
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

            //CompositeMenu root = new CompositeMenu("公司");

            //CompositeMenu office1 = new CompositeMenu("第一處");
            //office1.Add(new CompositeMenu("第一科"));
            //office1.Add(new CompositeMenu("第二科"));
            //CompositeMenu office2 = new CompositeMenu("第二處");
            //office2.Add(new CompositeMenu("第四科"));
            //office2.Add(new CompositeMenu("第五科"));
            //office2.Add(new CompositeMenu("第六科"));

            //root.Add(office1);
            //root.Add(office2);

            //root.Display();

            //------------------------------------------------------------------------------------
            // Facade
            //HomeFacade facade = new HomeFacade();

            //facade.ArriveHome();
            //facade.LeaveHome();

            //------------------------------------------------------------------------------------
            // FlyWeight

            //Random random = new Random();
            //PokerFactory factory = new PokerFactory();

            //for (int i = 0; i < 10; i++)
            //{
            //    //先決定花色               
            //    Card card = null;
            //    switch(random.Next(0, 4))
            //    {
            //        case 0:
            //            card = factory.GetCard(PokerEnum.Spade);
            //            break;
            //        case 1:
            //            card = factory.GetCard(PokerEnum.Heart);
            //            break;
            //        case 2:
            //            card = factory.GetCard(PokerEnum.Clud);
            //            break;
            //        case 3:
            //            card = factory.GetCard(PokerEnum.Diamond);
            //            break;
            //    }

            //    if (card != null)
            //    {
            //        int num = random.Next(1, 14);
            //        switch (num)
            //        {
            //            case 11:
            //                card.ShowCard("J");
            //                break;
            //            case 12:
            //                card.ShowCard("Q");
            //                break;
            //            case 13:
            //                card.ShowCard("K");
            //                break;
            //            default:
            //                card.ShowCard(num.ToString());
            //                break;                       
            //        }
            //    }

            //}
            //------------------------------------------------------------------------------------
            // Prox
            //MathProxy proxy = new MathProxy();

            //proxy.Add(1, 3);
            //proxy.Dev(1, 3);
            //proxy.Mul(1, 3);
            //proxy.Sub(1, 3);          

            //------------------------------------------------------------------------------------
            // command

            //Exercise_DesignPattern.Pattern.Command.Light lamp = new Exercise_DesignPattern.Pattern.Command.Light();
            //Exercise_DesignPattern.Pattern.Command.ICommand switchUp = new Exercise_DesignPattern.Pattern.Command.FlipUpCommand(lamp);
            //Exercise_DesignPattern.Pattern.Command.ICommand switchDown = new Exercise_DesignPattern.Pattern.Command.FlipDownCommand(lamp);

            //Exercise_DesignPattern.Pattern.Command.Switch s = new Exercise_DesignPattern.Pattern.Command.Switch();

            //s.StoreAndExecute(switchUp);
            //s.StoreAndExecute(switchDown);

            //------------------------------------------------------------------------------------
            //Interpreter
            //Context context = new Context() { Text = "0123456789" };

            //TranslateUpperChinese upper = new TranslateUpperChinese();            
            //Console.WriteLine(upper.Interpret(context));

            //TranslateLowerChinese lower = new TranslateLowerChinese();
            //Console.WriteLine(lower.Interpret(context));

            //------------------------------------------------------------------------------------
            // Iterator
            //DaysOfTheWeek days = new DaysOfTheWeek();

            //foreach (var d in days)
            //    Console.WriteLine(d);

            //------------------------------------------------------------------------------------
            // Mediator

            //Chatroom chatroom = new Chatroom();

            //Participant p1 = new Participant("p1");
            //Participant p2 = new Participant("p2");
            //Participant p3 = new Beatle("p3");

            //chatroom.Register(p1);
            //chatroom.Register(p2);
            //chatroom.Register(p3);

            //p1.Send("p2", "hello p2");
            //p2.Send("p3", "hello p3");

            //------------------------------------------------------------------------------------
            //Memento

            //List<ContactPerson> persons = new List<ContactPerson>
            //{
            //    new ContactPerson() { Name = "aaa", MobileNum = "11111" },
            //    new ContactPerson() { Name = "bbb", MobileNum = "22222" },
            //    new ContactPerson() { Name = "ccc", MobileNum = "22222" }
            //};

            //MobileOwner owner = new MobileOwner(persons);

            //ContactMemento memento = owner.CreateMemento();

            //owner.Show();

            //owner.ContactPersons.RemoveAt(1);

            //owner.Show();

            //owner.RestoreMemento(memento);

            //owner.Show();
            //------------------------------------------------------------------------------------
            // State

            //Player user = new Player();

            //user.level = 1; // 玩家等級
            //user.stateWork(); // 玩家狀態處理

            //user.level = 20;
            //user.stateWork();

            //user.level = 62;
            //user.stateWork();

            //user.level = 93;
            //user.stateWork();

            //------------------------------------------------------------------------------------
            // TemplateMethod

            //DataAccessObject daoCategories = new Categories();
            //daoCategories.Run();

            //DataAccessObject daoProducts = new Products();
            //daoProducts.Run();

            //------------------------------------------------------------------------------------
            // Visitor

            //CompanyStructure structure = new CompanyStructure();

            //Chairman chairman = new Chairman("Chairman");
            //Manager manager = new Manager("Manager");

            //structure.Elements.Add(chairman);
            //structure.Elements.Add(manager);

            //Visitor salary = new Salary();

            //structure.Accept(salary);

            //------------------------------------------------------------------------------------

            // 管理者初始化
            Exercise_DesignPattern.Pattern.Chain.Manager manager = new Exercise_DesignPattern.Pattern.Chain.Manager("阿福"); // 經理
            Exercise_DesignPattern.Pattern.Chain.Director director = new Exercise_DesignPattern.Pattern.Chain.Director("技安"); // 協理
            Exercise_DesignPattern.Pattern.Chain.GeneralManager generalmanager = new Exercise_DesignPattern.Pattern.Chain.GeneralManager("宜靜"); // 總經理
            manager.SetUpManager(director); // 設定經理的上級為協理
            director.SetUpManager(generalmanager); // 設定協理的上級為總經理

            Exercise_DesignPattern.Pattern.Chain.LeaveRequest leaveRequest = new Exercise_DesignPattern.Pattern.Chain.LeaveRequest(); // 假單
            leaveRequest.Name = "大雄"; // 員工姓名

            leaveRequest.DayNum = 1; // 請假天數
            manager.RequestPersonalLeave(leaveRequest);// 送出1天的假單

            leaveRequest.DayNum = 3; // 請假天數
            manager.RequestPersonalLeave(leaveRequest);// 送出3天的假單

            leaveRequest.DayNum = 7; // 請假天數
            manager.RequestPersonalLeave(leaveRequest);// 送出7天的假單

            leaveRequest.DayNum = 10; // 請假天數
            manager.RequestPersonalLeave(leaveRequest);// 送出10天的假單

            //------------------------------------------------------------------------------------

            Console.ReadLine();
        }
    }
}
