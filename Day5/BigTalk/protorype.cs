using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigTalk
{
    abstract class Prototype
    {
        private string id;

        public Prototype(string id)
        {
            this.id = id;
        }

        public string ID
        {
            get { return id; }
        }

        public abstract Prototype Clone();
    }

    class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(string id):base(id)
        {
        }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
