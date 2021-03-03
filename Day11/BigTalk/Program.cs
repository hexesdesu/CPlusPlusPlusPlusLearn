using System;

namespace BigTalk
{
    class Program
    {
        static void Main(string[] args)
        {
            //Target target = new Adapter();
            //target.Reqest();

            Player b = new Forwards("巴蒂尔");
            b.Attack();
            Player m = new Guards("麦克格雷迪");
            m.Attack();

            Player ym = new Translator("姚明");

            ym.Attack();
            ym.Defense();

            Console.Read();
        }
    }
}
