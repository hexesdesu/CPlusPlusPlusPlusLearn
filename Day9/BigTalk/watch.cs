using System;
using System.Collections.Generic;
using System.Text;

namespace BigTalk
{
    abstract class Subject
    {
        private IList<Observer> observers = new List<Observer>();
        public void Attach(Observer observer) => observers.Add(observer);
        public void Detach(Observer observer) => observers.Remove(observer);
        public void Notify()
        {
            foreach (var o in observers)
                o.Update();
        }
    }

    abstract class Observer
    {
        public abstract void Update();
    }

    class ConcreteSubject : Subject
    {
        public string SubjectState { get; set; }
    }

    class ConcreteObserver : Observer
    {
        private string name;
        private string observerState;
        public ConcreteSubject Subject { get; set; }
        public ConcreteObserver(ConcreteSubject subject,string name)
        {
            Subject = subject;
            this.name = name;
        }
        public override void Update()
        {
            observerState = Subject.SubjectState;
            Console.WriteLine($"Observer {name}'s new state is {observerState}");
        }
    }
}
