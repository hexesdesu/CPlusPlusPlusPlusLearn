using System;
using System.Collections.Generic;
using System.Text;

namespace BigTalk
{
    public sealed class Singleton
    {
        private static readonly Singleton instance=new Singleton();
        private Singleton() { }
        public static Singleton GetInstance()
        {
            return instance;
        }
    }
}
