using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DesignPattern.Pattern.Prototype
{
    /*
    原型模式
    區分為「淺複製」與「深複製」 
    淺複製：複製所有欄位，參考型別只複製參考。 
    深複製：建立新的物件。

    http://goodmanroc.blogspot.tw/2011/07/design-patterns-prototype.html
    */

    /*
    淺複製
    */

    public class WorkExperience
    {
        public DateTime WorkDate { get; set; }
        public string Company { get; set; }
    }

    public class Resume : ICloneable
    {
        private WorkExperience _work;

        public Resume()
        {
            _work = new WorkExperience();
        }
        public string Name { get; set; }
        public int Age { get; set; }

        public void SetWork(DateTime dt, string company)
        {
            _work.WorkDate = dt;
            _work.Company = company;
        }

        public void Display()
        {
            Console.WriteLine("{0}({1}):{2}-{3}", Name, Age, _work.Company, _work.WorkDate.ToString("yyyy/MM/dd"));
        }

        public object Clone()
        {
            //淺複製：複製所有欄位，參考型別只複製參考。 
            return this.MemberwiseClone();
        }
    }

    public class WorkExperience_Deep : ICloneable
    {
        public DateTime WorkDate { get; set; }
        public string Company { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }

    }

    public class Resume_Deep : ICloneable
    {
        private WorkExperience_Deep _work;

        public Resume_Deep()
        {
            _work = new WorkExperience_Deep();
        }
        public string Name { get; set; }
        public int Age { get; set; }

        public void SetWork(DateTime dt, string company)
        {
            _work.WorkDate = dt;
            _work.Company = company;
        }

        public void Display()
        {
            Console.WriteLine("{0}({1}):{2}-{3}", Name, Age, _work.Company, _work.WorkDate.ToString("yyyy/MM/dd"));
        }

        public object Clone()
        {
            //深複製：建立新的物件。
            Resume_Deep result = new Resume_Deep();
            result.Name = this.Name;
            result.Age = this.Age;
            result.SetWork(this._work.WorkDate, this._work.Company);

            return result;
        }
    }
}
