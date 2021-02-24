using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigTalk
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 笨办法
            Resume a = new Resume("大鸟");
            a.SetPersonalInfo("男", "29");
            a.SetWorkExperience("1998-2000", "XX公司");

            Resume b = a;
            Resume c = a;

            a.Display();
            b.Display();
            c.Display();

            Console.Read();
            **/


            /* 原型模式
            ConcretePrototype1 p1 = new ConcretePrototype1("I");
            ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
            Console.WriteLine("Cloned:{0}", c1.ID);

            Console.Read();
            **/

            Resume a = new Resume("大鸟");
            a.SetPersonalInfo("男", "29");
            a.SetWorkExperience("1998-2000", "XX公司");

            Resume b = (Resume)a.Clone();
            b.SetWorkExperience("1998-2006", "YY企业");

            Resume c = (Resume)a.Clone();
            c.SetPersonalInfo("男", "24");
            c.SetWorkExperience("1998-2003", "ZZ企业");

            a.Display();
            b.Display();
            c.Display();

            Console.Read();
        }
    }
}
