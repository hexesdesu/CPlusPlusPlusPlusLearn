using System;
using System.Collections.Generic;
using System.Text;

namespace BigTalk
{
    public class Barbecuer
    {
        public void BakeMutton()
        {
            Console.WriteLine("烤羊肉串！");
        }
        public void BakeChickenWing()
        {
            Console.WriteLine("烤鸡翅！");
        }
    }

    public abstract class Command
    {
        protected Barbecuer receiver;
        public Command(Barbecuer receiver)
        {
            this.receiver = receiver;
        }
        abstract public void ExcuteCommmand();
    }

    class BakeMuttonCommand : Command
    {
        public BakeMuttonCommand(Barbecuer receiver) : base(receiver) { }
        public override void ExcuteCommmand()
        {
            receiver.BakeMutton();
        }
    }

    class BakeChickenWingCommand : Command
    {
        public BakeChickenWingCommand(Barbecuer receiver) : base(receiver) { }
        public override void ExcuteCommmand()
        {
            receiver.BakeChickenWing();
        }
    }

    public class Waiter
    {
        private Command command;
        public void SetOrder(Command command)
        {
            this.command = command;
        }
        public void Notify()
        {
            command.ExcuteCommmand();
        }
    }
}
