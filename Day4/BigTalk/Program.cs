using System;

namespace BigTalk
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 代理模式
            Proxy proxy = new Proxy();
            proxy.Request();
            **/

            /* 雷锋简单实现
            LeiFeng xueleifeng = new Undergraduate();
            xueleifeng.BuyRice();
            xueleifeng.Sweep();
            xueleifeng.Wash();
            **/

            /* 雷锋替代简单实现，但学生需要毕业
            LeiFeng student1 = new Undergraduate();
            student1.BuyRice();
            LeiFeng student2 = new Undergraduate();
            student1.Sweep();
            LeiFeng student3 = new Undergraduate();
            student1.Wash();
            **/

            /* 雷锋学生替代简单实现，有重复代码
            LeiFeng studentA = SimpleFactory.CreateLeiFeng("学雷锋的大学生");
            studentA.BuyRice();
            LeiFeng studentB = SimpleFactory.CreateLeiFeng("学雷锋的大学生");
            studentA.Sweep();
            LeiFeng studentC = SimpleFactory.CreateLeiFeng("学雷锋的大学生");
            studentA.Wash();
            **/

            /*雷锋工厂
            IFactory factory = new UnderGraduateFactory();
            LeiFeng student = factory.CreateLeiFeng();

            student.BuyRice();
            student.Sweep();
            student.Wash();
            **/

            Resume a = new Resume("大鸟");
            a.SetPersonalInfo("男", "29");
            a.SetWorkExperience("1998-2000", "XX公司");

            Resume b = new Resume("大鸟");
            b.SetPersonalInfo("男", "29");
            b.SetWorkExperience("1998-2000", "XX公司");

            Resume c = new Resume("大鸟");
            c.SetPersonalInfo("男", "29");
            c.SetWorkExperience("1998-2000", "XX公司");

            a.Display();
            b.Display();
            c.Display();


        }
    }
}
