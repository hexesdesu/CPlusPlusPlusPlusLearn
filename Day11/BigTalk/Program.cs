using System;

namespace BigTalk
{
    class Program
    {
        static void Main(string[] args)
        {
            GameRole lixiaoyao = new GameRole();

            lixiaoyao.GetInitState();
            lixiaoyao.StateDisplay();

            GameRole backup = new GameRole();
            backup.Vitality = lixiaoyao.Vitality;
            backup.Attack = lixiaoyao.Attack;
            backup.Defense = lixiaoyao.Defense;

            lixiaoyao.Fight();
            lixiaoyao.StateDisplay();

            lixiaoyao.Vitality = backup.Vitality;
            lixiaoyao.Attack = backup.Attack;
            lixiaoyao.Defense = backup.Defense;

            lixiaoyao.StateDisplay();

            Console.Read();
        }
    }
}
