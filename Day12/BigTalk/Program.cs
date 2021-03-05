using System;

namespace BigTalk
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Barbecuer boy = new Barbecuer();
            boy.BakeMutton();
            boy.BakeMutton();
            boy.BakeMutton();
            boy.BakeChickenWing();
            boy.BakeMutton();
            boy.BakeMutton();
            boy.BakeChickenWing();*/

            Barbecuer boy = new Barbecuer();
            Command bakeMuttonCommand1 = new BakeMuttonCommand(boy);
            Command bakeMuttonCommand2 = new BakeMuttonCommand(boy);
            Command bakeChickenWingCommad1 = new BakeChickenWingCommand(boy);
            Waiter girl = new Waiter();

            girl.SetOrder(bakeMuttonCommand1);
            girl.Notify();
            girl.SetOrder(bakeMuttonCommand2);
            girl.Notify();
            girl.SetOrder(bakeChickenWingCommad1);
            girl.Notify();

            Console.Read();
        }
    }
}
