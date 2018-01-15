using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DesignPattern.Pattern.AbstractFactory
{
    /*
    抽象工廠
    http://goodmanroc.blogspot.tw/2011/05/design-patterns-abstract-factory.html

    例:
    有一個專案，對於資料的存取，我們希望實現多資料庫，不侷限於某一個資料庫。 
    */

    public interface IUser
    {
        int InsertUser(string name);
    }

    public class AccessUser : IUser
    {
        public int InsertUser(string name)
        {
            Console.WriteLine("AccessUser.InsertUser");
            return 1;
        }
    }

    public class SqlServerUser : IUser
    {
        public int InsertUser(string name)
        {
            Console.WriteLine("SqlServerUser.InsertUser");
            return 2;
        }
    }

    public interface IFactory
    {
        IUser CreateUser();
    }

    public class AccessFactory : IFactory
    {
        public IUser CreateUser()
        {
            return new AccessUser();
        }
    }

    public class SqlServerFactory : IFactory
    {
        public IUser CreateUser()
        {
            return new SqlServerUser();
        }
    }
}
