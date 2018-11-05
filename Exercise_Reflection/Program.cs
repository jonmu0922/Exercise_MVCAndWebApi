using Exercise_Reflection.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            string typename = "Exercise_Reflection.Core.Person";
            string methodname = "Hello";
            //Type type = Type.GetType(typename);

            //// 建立實體
            //object instance = Activator.CreateInstance(type, null);

            //// 取得method
            //MethodInfo methodInfo = type.GetMethod(methodname);

            object[] parameters = new object[] { "jon" };
            object[] parameters1 = new object[] { "jon", 5 };
            object[] parameters2 = new object[] { "jon", null };
            //var result = methodInfo.Invoke(instance, parameters);

            var result = ReflectionHelper.CallMethod<string>(typename, methodname, parameters);
            Console.WriteLine(result.ToString());
            var result1 = ReflectionHelper.CallMethod<string>(typename, methodname, parameters1);
            Console.WriteLine(result1.ToString());
            var result2 = ReflectionHelper.CallMethod<string>(typename, methodname, parameters2);          
            Console.WriteLine(result2.ToString());

            //Console.WriteLine(instance.ToString());
            Console.ReadLine();

        }
    }
}
