using System;
using System.Collections.Generic;
using System.Text;

namespace BigTalk
{
    class Secretary
    {
        private IList<Observer> observers = new List<Observer>();
        private string action;

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notiry()
        {
            foreach (Observer o in observers)
                o.Update();
        }

        public string SecretaryAction
        {
            get { return action; }
            set { action = value; }
        }
    }

    abstract class Observer
    {
        protected string name;
        protected Secretary sub;

        public Observer(string name, Secretary sub)
        {
            this.name = name;
            this.sub = sub;
        }

        public abstract void Update();
    }

    class StockObserver:Observer
    {
        public StockObserver (string name,Secretary sub) : base(name, sub) { }

        public override void Update()
        {
            Console.WriteLine("{0}{1}Close stock and back to work!", sub.SecretaryAction, name);
        }

    }

    class NBAObserver:Observer
    {
        public NBAObserver(string name, Secretary sub) : base(name, sub) { }

        public override void Update()
        {
            Console.WriteLine("{0}{1}Close NBA and back to work!", sub.SecretaryAction, name);
        }
    }
}
