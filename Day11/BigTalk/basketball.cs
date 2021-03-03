using System;
using System.Collections.Generic;
using System.Text;

namespace BigTalk
{
    abstract class Player
    {
        protected string name;
        public Player(string name)
        {
            this.name = name;
        }
        public abstract void Attack();
        public abstract void Defense();
    }

    class Forwards : Player
    {
        public Forwards(string name) : base(name) { }
        public override void Attack()
        {
            Console.WriteLine("前锋{0}进攻", name);
        }
        public override void Defense()
        {
            Console.WriteLine("前锋{0}防守", name);
        }
    }

    class Center : Player
    {
        public Center(string name) : base(name) { }
        public override void Attack()
        {
            Console.WriteLine("中锋{0}进攻", name);
        }
        public override void Defense()
        {
            Console.WriteLine("中锋{0}防守", name);
        }
    }

    class Guards : Player
    {
        public Guards(string name) : base(name) { }
        public override void Attack()
        {
            Console.WriteLine("后卫{0}进攻", name);
        }
        public override void Defense()
        {
            Console.WriteLine("后卫{0}防守", name);
        }
    }

    class ForeignCenter
    {
        private string name;
        public string Name
        {
            get;
            set;
        }

        public void 进攻()
        {
            Console.WriteLine("外援中锋{0}进攻", name);
        }
        public void 防守()
        {
            Console.WriteLine("外援中锋{0}防守", name);
        }
    }

    class Translator : Player
    {
        private ForeignCenter wjzf = new ForeignCenter();

        public Translator(string name) : base(name)
        {
            wjzf.Name = name;
        }

        public override void Attack()
        {
            wjzf.进攻();
        }

        public override void Defense()
        {
            wjzf.防守();
        }
    }
}
