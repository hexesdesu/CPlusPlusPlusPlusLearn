﻿using System;

namespace BigTalk
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate a = new ConcreteAggregate();

            a[0] = "大鸟";
            a[1] = "小菜";
            a[2] = "行李";
            a[3] = "老外";
            a[4] = "公交内部员工";
            a[5] = "小偷";

            //Iterator i = new ConcreteIterator(a);
            Iterator i = new ConcreteIteratorDesc(a);

            object item = i.First();
            while (!i.IsDone())
            {
                Console.WriteLine("{0} 请买车票！", i.CurrentItem());
                i.Next();
            }

            Console.Read();
        }
    }
}
