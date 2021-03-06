﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BigTalk
{
    class Originator
    {
        private string state;
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        public Memento CreateMemento()
        {
            return (new Memento(state));
        }
        public void SetMemento(Memento memento)
        {
            state = memento.State;
        }
        public void Show()
        {
            Console.WriteLine("State=" + state);
        }
    }

    class Memento
    {
        private string state;
        public Memento(string state)
        {
            this.state = state;
        }
        public string State
        {
            get { return state; }
        }
    }

    class Caretaker
    {
        private Memento memento;
        public Memento Memento
        {
            get { return memento; }
            set { memento = value; }
        }
    }
}
