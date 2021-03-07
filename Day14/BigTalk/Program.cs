using System;

namespace BigTalk
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ConcreteMediator m = new ConcreteMediator();

            ConcreteColleague1 c1 = new ConcreteColleague1(m);
            ConcreteColleague2 c2 = new ConcreteColleague2(m);

            m.Colleague1 = c1;
            m.Colleague2 = c2;

            c1.Send("吃了么？");
            c2.Send("么得。");*/

            UnitedNationsSecurityCouncil UNSC = new UnitedNationsSecurityCouncil();

            USA c1 = new USA(UNSC);
            Iraq c2 = new Iraq(UNSC);

            UNSC.Colleague1 = c1;
            UNSC.Colleague2 = c2;

            c1.Declare("不准研制核武器，否则要发动战争！");
            c2.Declare("我们没有核武器，也不怕侵略。");

            Console.Read();
        }
    }
}
