using System;
using System.Collections.Generic;
using System.Text;

namespace BigTalk
{
    abstract class State
    {
        public abstract void Handle(Context context);
    }

    class ConcreteStateA : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }

    class ConcreteStateB : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }

    class Context
    {
        private State state;
        public Context(State state)
        {
            this.state = state;
        }
        public State State
        {
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine("当前状态：" + state.GetType().Name);
            }
        }
        public void Request()
        {
            state.Handle(this);
        }
    }
}
