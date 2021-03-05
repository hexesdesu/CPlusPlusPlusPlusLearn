using System;
using System.Collections.Generic;
using System.Text;

namespace BigTalk
{
    abstract class Command
    {
        protected Receiver receiver;
        public Command(Receiver receiver)
        {
            this.receiver = receiver;
        }
        abstract public void Excute();
    }

    class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver) :base(receiver) { }
        public override void Excute()
        {
            receiver.Action();
        }
    }

    class Invoker
    {
        private Command command;
        public void SetCommand(Command command)
        {
            this.command = command;
        }
        public void ExcuteCommand()
        {
            command.Excute();
        }
    }

    class Receiver
    {
        public void Action()
        {
            Console.WriteLine("执行请求！");
        }
    }
}
