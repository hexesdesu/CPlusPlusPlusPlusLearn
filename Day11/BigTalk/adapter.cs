using System;
using System.Collections.Generic;
using System.Text;

namespace BigTalk
{
    class Target
    {
        public virtual void Reqest()
        {
            Console.WriteLine("普通请求！");
        }
    }

    class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("特殊请求");
        }
    }

    class Adapter : Target
    {
        private Adaptee adaptee = new Adaptee();
        public override void Reqest()
        {
            adaptee.SpecificRequest();
        }
    }

}
