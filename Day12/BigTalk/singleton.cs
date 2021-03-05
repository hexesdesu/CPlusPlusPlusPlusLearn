using System;
using System.Collections.Generic;
using System.Text;

namespace BigTalk
{
    class Singleton
    {
        private static Singleton instance;
        private static readonly object syncRoot = new object();
        private Singleton() { }
        public static Singleton GetInstance()
        {
            lock (syncRoot)
            { 
                if (instance == null)
                {
                    instance = new Singleton();
                }
            }
            return instance;
        }
    }
}
