using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Reflection.Core
{
    public class Person
    {
        public string Hello(string name)
        {
            return "Hello " + name;
        }

        public string Hello(string name, int? age)
        {
            return "Hello " + name + ", age= " + (age.HasValue ? age.Value.ToString() : "");

        }
    }
}
