using System;
using System.Collections.Generic;
using System.Text;

namespace BigTalk
{
    class Person
    {
        public Person()
        {  }
        private string name;
        public Person(string name)
        {
            this.name = name;
        }
        public virtual void Show()
        {
            Console.WriteLine("装扮的{0}",name)''
        }
    }
    class Finery : Person
    {
        protected Person component;
        public void Decorate(Person component)
        {
            this.component = component;
        }
        public override void Show()
        {
            if (componet != null)
            {
                component.Show();
            }
        }
    }
    class TShirts : Finery
    {
        public override void Show()
        {
            Console.Write("大T恤");
            base.Show();
        }
    }
    class BigTrouser : Finery
    {
        public override void Show()
        {
            Console.Write("跨库");
            base.Show();
        }
    }
}
