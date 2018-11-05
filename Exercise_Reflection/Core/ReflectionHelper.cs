using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Reflection.Core
{
    public class ReflectionHelper
    {
        public static T CallMethod<T>(string typename, string methodname, params object[] parameters)
        {
            Type type = Type.GetType(typename);

            // 建立實體
            object instance = Activator.CreateInstance(type, null);

            // 取得method
            //MethodInfo methodInfo = type.GetMethod(methodname, parameters.Select(o=>o?.GetType()).ToArray());
            MethodInfo methodInfo = type.GetMethod(methodname, parameters.Select(o=>o == null ? null : o.GetType()).ToArray());

            return (T)methodInfo.Invoke(instance, parameters);
        }
    }
}
