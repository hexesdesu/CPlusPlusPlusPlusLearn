﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BigTalk
{
    abstract class Subject
    {
        public abstract void Request();
    }
    class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("RealRequest");
        }
    }
    class Proxy : Subject
    {
        RealSubject realSubject;
        public override void Request()
        {
            if (realSubject == null)
            {
                realSubject = new RealSubject();
            }
            realSubject.Request();
        }
    }
}

