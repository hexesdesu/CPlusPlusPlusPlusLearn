using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigTalk
{
    abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleague);
    }

    abstract class Colleague
    {
        protected Mediator mediator;
        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }

    class ConcreteMediator : Mediator
    {
        private ConcreteColleague1 colleague1;
        private ConcreteColleague2 colleague2;
        public ConcreteColleague1 Colleague1
        {
            set { colleague1 = value; }
        }
        public ConcreteColleague2 Colleague2
        {
            set { colleague2 = value; }
        }
        public override void Send(string message, Colleague colleague)
        {
            if (colleague == colleague1)
            {
                colleague2.Notify(message);
            }
            else
            {
                colleague1.Notify(message);
            }
        }
    }
    class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(Mediator mediator) : base(mediator) { }
        public void Send(string message)
        {
            mediator.Send(message, this);
        }
        public void Notify(string message)
        {
            Console.WriteLine("同事1得到信息：" + message);
        }
    }
    class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Mediator mediator) : base(mediator) { }
        public void Send(string message)
        {
            mediator.Send(message, this);
        }
        public void Notify(string message)
        {
            Console.WriteLine("同事2得到信息：" + message);
        }
    }
}
