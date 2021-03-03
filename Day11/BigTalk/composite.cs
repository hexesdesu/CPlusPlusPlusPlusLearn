using System;
using System.Collections.Generic;
using System.Text;

namespace BigTalk
{
    abstract class Component
    {
        protected string name;
        public Component(string name)
        {
            this.name = name;
        }
        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int depth);
    }

    class Leaf : Component
    {
        public Leaf(string name) : base(name) { }
        public override void Add(Component c)
        {
            Console.WriteLine("Cannot add to a leaf");
        }
        public override void Remove(Component c)
        {
            Console.WriteLine("Cannot remove from a leaf");
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }
    }

    class Composite : Component
    {
        private List<Component> children = new List<Component>();
        public Composite(string name) : base(name) { }
        public override void Add(Component c)
        {
            children.Add(c);
        }
        public override void Remove(Component c)
        {
            children.Remove(c);
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);

            foreach(Component component in children)
            {
                component.Display(depth + 2);
            }
        }
    }
}