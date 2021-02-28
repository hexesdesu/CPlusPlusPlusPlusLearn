using System;
using System.Collections.Generic;
using System.Text;

namespace BigTalk
{
    abstract class Subject
    {
        private IList<Observer> observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach(Observer o in observers)
            {
                o.Update();
            }
        }
    }

    abstract class Observer
    {
        public abstract void Update();
    }

    class ConcreteSubject : Subject
    {
        private string subjectState;

        public string SubjectState
        {
            get;
            set;
        }
    }

    class ConcreteObserver : Observer
    {
        private string name;
        private string observerState;
        private ConcreteSubject subject;

        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            this.subject = subject;
            this.name = name;
        }

        public override void Update()
        {
            observerState = subject.SubjectState;
            Console.WriteLine("Watcher {0}'s new state is {1}", name, observerState);
        }

        public ConcreteSubject Subject
        {
            get;
            set;
        }
    }
}
